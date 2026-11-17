<?php
if (!isset($_COOKIE["playerObjects"])) {
    $players = array();
    setcookie("playerObjects", json_encode($players));
}
if (isset($_POST["btnSave"])) {
    $players = json_decode($_COOKIE["playerObjects"]);

    array_push($players, array(
        "names" => $_POST["txtBoxName"],
        "scores" => array($_POST["txtBoxM1"], $_POST["txtBoxM2"], $_POST["txtBoxM3"])
    ));

    setcookie("playerObjects", json_encode($players));
}
?>

<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Array and Cookie</title>
</head>

<body>
    <form method="post">
        <table>
            <tr>
                <td>Player</td>
                <td><input type="text" name="txtBoxName"></td>
            </tr>
            <tr>
                <td>Score</td>
                <td>
                    <table>
                        <tr>
                            <td>Match 1</td>
                            <td>Match 2</td>
                            <td>Match 3</td>
                        </tr>
                        <tr>
                            <td><input type="number" name="txtBoxM1"></td>
                            <td><input type="number" name="txtBoxM2"></td>
                            <td><input type="number" name="txtBoxM3"></td>
                        </tr>
                    </table>
                </td>
            </tr>
            <tr>
                <td colspan="2">
                    <input type="submit" value="Save" name="btnSave">
                    <input type="submit" value="Print All" name="btnPrint">
                    <input type="submit" value="Average Score" name="btnAvg">
                    <input type="submit" value="Total Score By Player" name="btnPTotal">
                    <input type="submit" value="Total Average By Player" name="btnPAvg">
                </td>
            </tr>
        </table>
    </form>
    <?php
    if (isset($_POST["btnPrint"])) {
        $players  = json_decode($_COOKIE["playerObjects"]);

        foreach ($players as $p) {
            echo $p->names, '<br>';
            foreach ($p->scores as $s) {
                if ($s !== "") {
                    echo $s, '<br>';
                }
            }
        }
    }
    ?>
</body>

</html>