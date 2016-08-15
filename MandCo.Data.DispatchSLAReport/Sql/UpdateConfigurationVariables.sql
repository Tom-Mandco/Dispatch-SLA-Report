Update Web_Proc_Ctrl wpc
SET wpc.delimiteddatastring = ( 
CASE(wpc.recordsubtype)
      WHEN 'EXPSLA' then @0
      WHEN 'EXPCUT' then @1
      WHEN 'EXPSLAPC1' then @2 
      WHEN 'EXPSLAPC2' then @3
    WHEN 'INTSLA' then @4
      WHEN 'INTCUT' then @5
      WHEN 'INTSLAPC1' then @6 
      WHEN 'INTSLAPC2' then @7
    WHEN 'STDSLA' then @8
      WHEN 'STDCUT' then @9
      WHEN 'STDSLAPC1' then @10 
      WHEN 'STDSLAPC2' then @11
    WHEN 'STRSLA' then @12
      WHEN 'STRCUT' then @13
      WHEN 'STRSLAPC1' then @14 
      WHEN 'STRSLAPC2' then @15
    ELSE ' '
    END)
WHERE wpc.recordtype = 'ws1160'


