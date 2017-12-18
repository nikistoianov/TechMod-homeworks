<?php

for ($i = 1; $i <= 5; $i++) {
    echo "<button style='background-color: blue'>1</button>";
}
echo "<br>";

for ($i = 1; $i <= 3; $i++) {
    echo "<button style='background-color: blue'>1</button>";
    for ($ii = 1; $ii <= 4; $ii++) {
        echo "<button>0</button>";
    }
    echo "<br>";
}

for ($i = 1; $i <= 5; $i++) {
    echo "<button style='background-color: blue'>1</button>";
}
echo "<br>";

for ($i = 1; $i <= 3; $i++) {
    for ($ii = 1; $ii <= 4; $ii++) {
        echo "<button>0</button>";
    }
    echo "<button style='background-color: blue'>1</button>";
    echo "<br>";
}

for ($i = 1; $i <= 5; $i++) {
    echo "<button style='background-color: blue'>1</button>";
}
echo "<br>";

?>