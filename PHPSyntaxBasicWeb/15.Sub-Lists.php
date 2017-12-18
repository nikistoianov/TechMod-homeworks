<ul>
<?php

$n1 = intval($_GET['num1']);
$n2 = intval($_GET['num2']);

for ($i1 = 1; $i1 <=$n1; $i1++) {
    echo "<li>List $i1 <ul>";
    for ($i2 = 1; $i2 <=$n2; $i2++) {
        echo "<li>Element $i1.$i2</li>";
    }

    echo "</ul></li>";
}
?>
</ul>