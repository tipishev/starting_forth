( demonstrates usage of the return stack )
: QUADRATIC  ( a b c x -- n )
    >R SWAP ROT R@ *  + R> *  + ;
