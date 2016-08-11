Select ord.order_number,
       ord.ship_method,
       ord.del_option,
       ord.order_date,
       orig.orig_date Date_Imported,
       rel.release_date,
       shp.ship_date
From   (select unique to_char(o.order_number) order_number, 
          case when o.deliver_to = 2 then 'Store' else
            case when lower(p.ship_method) like '%express%' then 'Home' else 
              case when (lower(p.ship_method) like '%standard%' or lower(p.ship_method) like '%free%') 
                        and lower(p.ship_method) not like '%european%' 
                        and lower(p.ship_method) not like '%worldwide%' 
                        and lower(p.ship_method) not like '%russia%' 
                        and lower(p.ship_method) not like '%international%' then 'Standard' else
              'International' end end end ship_method,
           o.order_date,
           o.del_country_code,
           o.source_channel,
           o.del_option
           from pos_order_ship_price p,
                pos_channel_orders o
           where o.order_number = p.order_number
           and   o.last_update >= to_date(@0, 'YYYY-MM-DD HH24-MI-SS')
           and   o.last_update <= to_date(@1, 'YYYY-MM-DD HH24-MI-SS')
           and   o.order_status <> 9
           and   exists (select 1 from pos_channel_order_items i 
                         where i.order_number = o.order_number 
                         and i.source_channel = o.source_channel 
                         and i.fulfil_store_flag <> 'Y')
           ) ord,
       (select unique wo.order_number order_number, 
           min(wo.last_update) release_date
           from pos_channel_order_audit wo
           where wo.order_status = 2
           group by wo.order_number
       ) rel,
       (select unique vp.order_number order_number, 
           max(vp.despatch_date) ship_date 
           from pos_order_package vp
           where vp.despatch_by <> 'ep2050'
           group by vp.order_number 
       ) shp,
       (select unique po.order_number order_number, 
           min(po.last_update) orig_date 
           from pos_channel_order_audit po
           group by po.order_number 
       ) orig
Where  ord.order_number = rel.order_number (+)
And    ord.order_number = shp.order_number (+)
And    ord.order_number = orig.order_number 
