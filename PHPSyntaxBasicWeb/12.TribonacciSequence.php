<?php

if(isset($_GET['num'])) {
    $n = intval($_GET['num']);
    $p1 = 1;
    $p2 = 0;
    $p3 = 0;
    echo "1";
    for ($i=1; $i<=$n; $i++) {
        $c = $p1 + $p2 + $p3;
        echo " " . $c;
        $p3 = $p2;
        $p2 = $p1;
        $p1 = $c;
    }
}