<?php
// // Sir's Method
// if (isset($_POST["txtNum1"]) && isset($_POST["txtNum2"])) {
//     $n1 = $_POST["txtNum1"];
//     $n2 = $_POST["txtNum2"];
//     $total = $n1 - $n2;
//     echo $total;
// }
// if (isset($_POST['btnAdd'])) {
//     $total = $n1 + $n2;
// }
?>

<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Calc</title>
</head>

<body>
    <form method="post">
        <ul style="list-style-type: none;">
            <?php
            if (isset($_POST['btnAdd'])) {
                $number1 = $_POST['txtNum1'];
                $number2 = $_POST['txtNum2'];
                $sum = $number1 + $number2;
            } elseif (isset($_POST['btnSub'])) {
                $number1 = $_POST['txtNum1'];
                $number2 = $_POST['txtNum2'];
                $sum = $number1 - $number2;
            } elseif (isset($_POST['btnMulti'])) {
                $number1 = $_POST['txtNum1'];
                $number2 = $_POST['txtNum2'];
                $sum = $number1 * $number2;
            } elseif (isset($_POST['btnDiv'])) {
                $number1 = $_POST['txtNum1'];
                $number2 = $_POST['txtNum2'];
                $sum = $number1 / $number2;
            }
            ?>
            <li>Enter Number 1</li>
            <li><input type="number" name="txtNum1" required value="<?php echo $number1 ?>"></li>
            <li>Enter Number 2</li>
            <li><input type="number" name="txtNum2" required value="<?php echo $number2 ?>"></li>
            <li>
                <input type="submit" name="btnAdd" value="+">
                <input type="submit" name="btnSub" value="-">
                <input type="submit" name="btnMulti" value="*">
                <input type="submit" name="btnDiv" value="/">
            </li>
            <li>Result</li>
            <li><input type="number" name="txtRes" value="<?php echo $sum ?>" readonly></li>
        </ul>
    </form>
</body>

</html>