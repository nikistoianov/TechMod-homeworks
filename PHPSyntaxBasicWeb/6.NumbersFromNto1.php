<?php

if(isset($_GET['num'])) {
    $n = intval($_GET['num']);
    for ($i=$n; $i>0; $i--) {
        echo $i . " ";
    }
}