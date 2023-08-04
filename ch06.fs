( copied from chapter 5 )

: r%  10 */  5 +  10 / ;

: compound ( amt int  -- )
    cr swap 21 1
    do
        ." year " i . 3 spaces
        2dup r% + dup ." balance " . cr
    loop
    2drop ;

: rectangle 256 0 do i 16 mod 0= if cr then ." *" loop ;

: poem
    cr
    11 1 do
        i . ." little "
        i 3 mod 0= if
                ." indians " cr
            then
    loop
    ." indian boys. " ; 

: multiplications 11 1 do dup i * . loop ;
: table 11 1 do cr i multiplications loop ;

: table2  CR
    11 1 DO
        11 1 DO  I J *  5 U.R
        LOOP
        CR
    LOOP ;

: inc-count ( increment limit index -- )
    do i . dup +loop drop ;

: TEST  100 10 DO  I . -1 +LOOP ;