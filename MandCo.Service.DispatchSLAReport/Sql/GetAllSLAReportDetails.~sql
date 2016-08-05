select ws.*, 
       nvl(trunc(ws.released_date - ws.order_date), 0) days_to_release, 
       nvl(trunc(mod((ws.released_date - ws.order_date)*24, 24 )), 0) hours_to_release, 
       nvl(trunc(mod((ws.released_date - ws.order_date)*24*60, 60 )), 0) mins_to_release
from WEB_WS1160_SLA_REPORT ws
where trunc(ws.order_date) >= to_date(':1', 'YYYY-MM-DD HH24-MI-SS')
and trunc(ws.order_date) <= to_date(':2', 'YYYY-MM-DD HH24-MI-SS')
and ws.sla_met = 'N'
order by ws.ship_method, ws.web_order_number
