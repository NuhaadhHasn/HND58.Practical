<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Cookie Work</title>
</head>

<body>
    <form method="get">
        <input type="submit" value="Click Me" name="btnClick">
        <input type="submit" value="Reset" name="btnReset">
    </form>
    <?php
    $count = 0;
    if (isset($_COOKIE["count"])) {
        $count = $_COOKIE["count"];
    } else {
        setcookie("count", 0);
    }
    if (isset($_GET['btnReset'])) {
        $count = 0;
        echo $count;
        setcookie("count", 0);
    }
    if (isset($_GET['btnClick'])) {
        $count++;
        echo $count;
        setcookie("count", $count);
    }

    ?>
</body>

</html>