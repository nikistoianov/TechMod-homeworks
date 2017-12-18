<?php

if(isset($_GET['num'])) {
    $n = intval($_GET['num']);
    $f = 1;
    for ($i=1; $i<=$n; $i++) {
        $f *= $i;
    }
    echo $f;
}