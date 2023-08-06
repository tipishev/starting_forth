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

\ : TEST  100 10 DO  I . -1 +LOOP ;

( exercises )

: star [char] * emit ;
( ex 1 ) : stars ( #stars -- ) 0 ?do star loop ;
( ex 2 ) : box ( width height -- ) 0 do cr dup stars loop ;
( ex 3 ) : \stars ( n -- ) 0 do cr i spaces 10 stars loop ;
( ex 4 ) : /stars ( n -- ) 0 swap do cr i spaces 10 stars -1 +loop ;
( ex 5 ) : /stars2 ( n -- ) begin cr dup spaces 10 stars 1 - dup 0= until drop ;
( ex 6, I gave up and copied the solution for studying :-/ )
: triangle ( increment limit start -- ) do cr 9 i - spaces i 2* 1+ stars dup +loop drop ;
: diamonds ( #diamonds -- ) 0 ?do 1 10 0 triangle -1 0 9 triangle loop ;
( ex 7 skipped, not interested )
( ex 8 ) : ** ( n exp -- n**exp ) 1 swap 0 do over * loop nip ;

