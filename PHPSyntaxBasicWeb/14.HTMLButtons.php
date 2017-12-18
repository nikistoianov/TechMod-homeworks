<?php

if(isset($_GET['num'])) {
    $n = intval($_GET['num']);

    for ($i = 1; $i <= $n; $i++) { ?>
        <button><?= $i ?></button>
        <?php
    }
}