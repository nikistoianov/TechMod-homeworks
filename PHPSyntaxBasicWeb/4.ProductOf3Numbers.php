<?php

if(isset($_GET['num1']) && isset($_GET['num2']) && isset($_GET['num3'])) {
    $n1 = intval($_GET['num1']);
    $n2 = intval($_GET['num2']);
    $n3 = intval($_GET['num3']);

    $isPositive = ($n1 < 0) + ($n2 < 0) + ($n3 < 0);
    if ($isPositive % 2 == 0 || $n1 == 0 || $n2 == 0 || $n3 == 0) {
        echo 'Positive';
    } else {
        echo 'Negative';
    }
}