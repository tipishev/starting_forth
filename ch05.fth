( task 5.1)

( a b c -- -ab/c )
: -ab/c */ negate ;

( n1 n2 n3 n4 -- )
: max4 max max max ;

( tests )

( n-observed n-expected -- )
: test
    2dup
    = if cr ." pass! " cr drop drop
    else cr ." fail: expected " . ." observed " .
    then 
;

( -- )
: test_all

    cr ." task 5.1 "
         12 3 6 -ab/c -6
     test

    cr ." task 5.2 "
        2 4 1 3 max4 4
    test
;


