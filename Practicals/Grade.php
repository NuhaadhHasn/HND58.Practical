<?php
// if (isset($_POST['btnSubmit'])) {
//     $number1 = $_POST['txtSub1'];
//     $number2 = $_POST['txtSub2'];
//     $number3 = $_POST['txtSub3'];
//     if ($number1 >= 75) {
//         $grade = "A";
//     } elseif ($number1 >= 60) {
//         $grade = "B";
//     } elseif ($number1 >= 50) {
//         $grade = "C";
//     } elseif ($number1 >= 40) {
//         $grade = "S";
//     } else {
//         $grade = "F";
//     }


//     if ($number2 >= 75) {
//         $grade2 = "A";
//     } elseif ($number2 >= 60) {
//         $grade2 = "B";
//     } elseif ($number2 >= 50) {
//         $grade2 = "C";
//     } elseif ($number2 >= 40) {
//         $grade2 = "S";
//     } else {
//         $grade2 = "F";
//     }


//     if ($number3 >= 75) {
//         $grade3 = "A";
//     } elseif ($number3 >= 60) {
//         $grade3 = "B";
//     } elseif ($number3 >= 50) {
//         $grade3 = "C";
//     } elseif ($number3 >= 40) {
//         $grade3 = "S";
//     } else {
//         $grade3 = "F";
//     }
// }

function findGrade($value)
{
    if ($value === "" || !is_numeric($value)) {
        return "";
    }
    $number1 = $value;
    if ($number1 >= 75) {
        $grade = "A";
    } elseif ($number1 >= 60) {
        $grade = "B";
    } elseif ($number1 >= 50) {
        $grade = "C";
    } elseif ($number1 >= 40) {
        $grade = "S";
    } else {
        $grade = "F";
    }
    return $grade;
}
?>

<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Find grade</title>
</head>

<body>
    <form method="post">
        <table>
            <tr>
                <td>Enter Subject 1 Marks</td>
                <!-- <td><input type="number" name="txtSub1" id="" value="<?php // echo $number1 
                                                                            ?>"></td> -->
                <td><input type="number" name="txtSub1" id="" value="<?php echo htmlspecialchars($_POST['txtSub1'] ?? '') ?>"></td>
                <td>Grade</td>
                <!-- <td><input type="text" name="txtRSub" value="<?php //echo $grade 
                                                                    ?>" readonly></td> -->
                <td><input type="text" name="txtRSub" value="<?php
                                                                if (isset($_POST['txtSub1']))
                                                                    echo findGrade($_POST['txtSub1']);
                                                                ?>" readonly></td>
            </tr>

            <tr>
                <td>Enter Subject 2 Marks</td>
                <!-- <td><input type="number" name="txtSub2" id="" value="<?php // echo $number2 
                                                                            ?>"></td> -->
                <td><input type="number" name="txtSub2" id="" value="<?php echo htmlspecialchars($_POST['txtSub2'] ?? '') ?>"></td>
                <td>Grade</td>
                <!-- <td><input type="text" name="txtRSub2" value="<?php // echo $grade2 
                                                                    ?>" readonly></td> -->
                <td><input type="text" name="txtRSub2" value="<?php
                                                                if (isset($_POST['txtSub2']))
                                                                    echo findGrade($_POST['txtSub2']);
                                                                ?>" readonly></td>
            </tr>

            <tr>
                <td>Enter Subject 3 Marks</td>
                <!-- <td><input type="number" name="txtSub3" id="" value="<?php // echo $number3 
                                                                            ?>"></td> -->
                <td><input type="number" name="txtSub3" id="" value="<?php echo htmlspecialchars($_POST['txtSub3'] ?? '') ?>"></td>
                <td>Grade</td>
                <!-- <td><input type="text" name="txtRSub3" value="<?php // echo $grade3 
                                                                    ?>" readonly></td> -->
                <td><input type="text" name="txtRSub3" value="<?php
                                                                if (isset($_POST['txtSub3']))
                                                                    echo findGrade($_POST['txtSub3']);
                                                                ?>" readonly></td>
            </tr>
            <tr>
                <td></td>
                <td colspan="3">
                    <input type="submit" name="btnSubmit" value="Find Grade">
                </td>
            </tr>
        </table>
    </form>
</body>

</html>