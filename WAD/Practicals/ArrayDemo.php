<?php
if (!isset($_COOKIE["player"])) {
    $names = array();
    setcookie("player", json_encode($names));
}
if (!isset($_COOKIE["score1"])) {
    $score1 = array();
    setcookie("score1", json_encode($score1));
}
if (!isset($_COOKIE["score2"])) {
    $score2 = array();
    setcookie("score2", json_encode($score2));
}
if (!isset($_COOKIE["score3"])) {
    $score3 = array();
    setcookie("score3", json_encode($score3));
}
if (isset($_POST["btnSave"])) {
    $names = json_decode($_COOKIE["player"]);
    $score1 = json_decode($_COOKIE["score1"]);
    $score2 = json_decode($_COOKIE["score2"]);
    $score3 = json_decode($_COOKIE["score3"]);

    array_push($names, $_POST["txtBoxName"]);
    array_push($score1, $_POST["txtBoxM1"]);
    array_push($score2, $_POST["txtBoxM2"]);
    array_push($score3, $_POST["txtBoxM3"]);

    setcookie("player", json_encode($names));
    setcookie("score1", json_encode($score1));
    setcookie("score2", json_encode($score2));
    setcookie("score3", json_encode($score3));
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
        $names = json_decode($_COOKIE["player"]);
        $score1 = json_decode($_COOKIE["score1"]);
        $score2 = json_decode($_COOKIE["score2"]);
        $score3 = json_decode($_COOKIE["score3"]);

        // foreach ($names as $n) {
        //     echo $n . '<br>';
        // }

        for ($count = 0; $count < count($names); $count++) {
            echo htmlspecialchars((string)$names[$count]), '<br>';
            if ($score1[$count] != "")
                echo htmlspecialchars((string)$score1[$count]), '<br>';
            if ($score2[$count] != "")
                echo htmlspecialchars((string)$score2[$count]), '<br>';
            if ($score3[$count] != "")
                echo htmlspecialchars((string)$score3[$count]), '<br>';
        }
    }
    ?>
</body>

</html>