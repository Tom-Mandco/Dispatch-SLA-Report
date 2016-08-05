select unique ws.web_order_number,
       ws.ship_method,
       ws.order_date,
       ws.released_date, 
       (nvl(trunc(ws.released_date - ws.order_date), 0) || ' days ' ||
       nvl(trunc(mod((ws.released_date - ws.order_date)*24, 24 )), 0) || ' hours ' ||
       nvl(trunc(mod((ws.released_date - ws.order_date)*24*60, 60 )), 0) || ' mins') Time_To_Release,
       ws.ship_date,
       (nvl(trunc(poca.last_update - ws.order_date), 0) || ' days ' ||
       nvl(trunc(mod((poca.last_update - ws.order_date)*24, 24 )), 0) || ' hours ' || 
       nvl(trunc(mod((poca.last_update - ws.order_date)*24*60, 60 )), 0) || ' mins') Time_To_Import,
       poca.last_update Date_Imported,
       ws.sla_met
From   WEB_WS1160_SLA_REPORT ws, POS_CHANNEL_ORDER_AUDIT poca, pos_channel_order_items pci
Where  ws.web_order_number = poca.order_number
and    ws.web_order_number in ('2961427', '2961452')
and    pci.source_channel = poca.source_channel 
and    pci.order_number = poca.order_number
and    pci.line_no = poca.order_line
and    poca.last_update = (Select min(p.last_update)
                           From POS_CHANNEL_ORDER_AUDIT p
                           Where ws.web_order_number = p.order_number)
and    Not Exists (Select * From web_grp_pick_nostk wgp
                   Where wgp.source_channel = pci.source_channel
                   and wgp.web_order_number = ws.web_order_number
                   and wgp.mac_sku = to_char(pci.product||lpad(pci.colour,4,0)||lpad(pci.item_size,4,0)))
Order by ws.ship_method, ws.web_order_number
