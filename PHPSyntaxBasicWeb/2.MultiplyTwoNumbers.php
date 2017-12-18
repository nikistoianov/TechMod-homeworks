<?php

if(isset($_GET['num1']) && isset($_GET['num1'])) {
    $n1 = intval($_GET['num1']);
    $n2 = intval($_GET['num2']);
    echo $n1 * $n2;
}