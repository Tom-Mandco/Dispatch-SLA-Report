select unique to_char(o.order_number) order_number, 
          case when o.deliver_to = 2 then 'Store' else 
            case when o.del_country_code in ('UK','GB',' ', null) then 'Home'
              else 'International' end end ship_method,
           o.del_option,
           o.order_date,
          (select min(a.last_update) 
           from pos_channel_order_audit a 
           where a.order_number = o.order_number 
           and a.source_channel = o.source_channel) date_imported,          
           case when o.order_status = 1 then null
             else case when o.source_channel <> 1 then (select min(a.last_update) 
                                                        from pos_channel_order_audit a 
                                                        where a.order_number = o.order_number 
                                                        and a.source_channel = o.source_channel 
                                                        and a.order_status = 2)
               else case when trim(o.corrected_by) is not null then o.date_corrected else
                 case when exists (select 1 
                                   from pos_channel_order_items i 
                                   where i.order_number = o.order_number 
                                   and i.source_channel = o.source_channel 
                                   and trim(i.corrected_by) is not null) 
                   then (select max(i.date_corrected) 
                         from pos_channel_order_items i 
                         where i.order_number = o.order_number 
                         and i.source_channel = o.source_channel)
                     else o.order_date end end end end release_date,
           (select max(vp.despatch_date) ship_date 
            from pos_order_package vp 
            where vp.despatch_by <> 'ep2050' 
            and vp.order_number = o.order_number 
            and vp.channel_number = o.source_channel) ship_date
from pos_channel_orders o 
where o.order_date >= to_date(@0, 'YYYY-MM-DD HH24-MI-SS')
and o.order_date <= to_date(@1, 'YYYY-MM-DD HH24-MI-SS')
and o.order_status <> 9
and exists (select 1 from pos_channel_order_items i 
            where i.order_number = o.order_number 
            and i.source_channel = o.source_channel 
            and i.fulfil_store_flag <> 'Y')
and not exists (select 1 from web_grp_pick_nostk wgpn 
                where wgpn.web_order_number = o.order_number 
                and wgpn.source_channel = o.source_channel
                and wgpn.stock_in_warehouse = 'N')
