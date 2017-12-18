<?php

if(isset($_GET['num'])) {
    $n = intval($_GET['num']);
    $p1 = 1;
    $p2 = 0;
    echo "1";
    for ($i=1; $i<=$n; $i++) {
        $c = $p1 + $p2;
        echo " " . $c;
        $p2 = $p1;
        $p1 = $c;
    }
}