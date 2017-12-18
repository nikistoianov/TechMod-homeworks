<?php

if(isset($_GET['num'])) {
    $n = intval($_GET['num']);
    for ($i=$n; $i>0; $i--) {
        if($i % 2 != 0) {
            echo $i . " ";
        }
    }
}