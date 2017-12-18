<?php

if(isset($_GET['num'])) {
    $n = intval($_GET['num']);

    $isPrime = function ($num) {
        if($num == 1 || $num == 0) {
            return false;
        }
        for ($ii = 2; $ii <= Math.Sqrt($num); $ii++) {
            if ($num % $ii == 0) {
                return false;
            }
        }
        return true;
    };

    for ($i = $n; $i > 0; $i--) {
        if ($isPrime($i) == true) {
            echo $i . " ";
        }
    }
}

?>

<?php

if(isset($_GET['num'])) {
    $n = intval($_GET['num']);

    for ($i = $n; $i > 1; $i--) {
        $isPrime = true;
        for ($ii = 2; $ii <= $i - 1; $ii++) {
            if ($i % $ii == 0) {
                $isPrime = false;
                break;
            }
        }

        if($isPrime) {
            echo $i . " ";
        }
    }
}