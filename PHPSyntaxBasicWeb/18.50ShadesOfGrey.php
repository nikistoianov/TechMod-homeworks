<head>
    <title>TTT</title>
    <style>
        div {
            display: inline-block;
            margin: 5px;
            width: 20px;
            height: 20px;
        }
    </style>
</head>
<body>

<?php
$color = 0;
for ($i = 1; $i <= 50; $i++) {
    if ($i == 11 || $i == 21 || $i == 31 || $i == 41) {
        $color += 1;
    }
    echo "<div style='background-color: rgb($color, $color, $color)'></div>";
    $color += 5;
    if ($i % 10 == 0) {
        echo "<br>";
    }
}
?>
</body>
