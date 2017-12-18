<?php

if(isset($_GET['num'])) {
    $n = intval($_GET['num']);
    echo $n * 2;
}