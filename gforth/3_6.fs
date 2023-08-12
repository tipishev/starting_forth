swap drop ( same as nip )
dup rot swap ( same as tuck )

1 2 3 -rot swap ( 3 2 1 )
1 2 3 over ( 1 2 3 2 )
1 2 3 swap drop dup ( 1 3 3 )
1 2 3 -rot swap rot ( 2 1 3 )
1 2 3 4 swap 2swap swap ( 4 3 2 1 )
: 3dup dup 2over rot ;
1 2 3 3dup ( 1 2 3 1 2 3 )
1 2 3 4 2over ( 1 2 3 4 1 2 )
1 2 3 nip ( 1 3 )

17 dup dup * *
17 dup dup dup * * *

: a-b/a+1  ( a b -- (a-b)(a+1) )
    over swap - swap 1 + * ;
