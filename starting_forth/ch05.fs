( n-observed n-expected -- )
: test
    2dup
    = if ." . " drop drop
    else cr ." fail: expected " . ." observed " .
    then 
;

( task 5.1) ( a b c -- -ab/c ) : -ab/c */ negate ;
( task 5.2) ( n1 n2 n3 n4 -- ) : max4 max max max ;

( task 5.4 ) ( K>F  )
( n-F -- n-C ) : F>C 32 - 10 18 */ ;
( n-C -- n-F ) : C>F 18 10 */ 32 + ;
( n-C -- n-K ) : C>K 273 + ;
( n-F -- n-K ) : F>K F>C C>K ; 
( n-K -- n-C ) : K>C 273 - ; 
( n-K -- n-F ) : K>F K>C C>F ; 

( -- )
: test_all

    cr ." task 5.4 "
        -40 F>C -40 test
        0 C>K 273 test 
        -40 F>K 233 test 

    ( cr ." task 5.1 " 12 3 6 -ab/c -6 test )
    ( cr ." task 5.2 " 2 4 1 3 max4 4 test )
;


