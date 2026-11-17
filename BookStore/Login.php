<?php
session_start();
include("User.php");

if (isset($_POST["btnLogin"])) {
    $user = new User();
    $user->UserName = $_POST["txtUsername"];
    $user->Password = $_POST["txtPassword"];
    $user->Login();
}
?>

<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Login</title>
</head>

<body>
    <form method="post">
        <table>
            <tr>
                <h1>Login</h1>
            </tr>
            <tr>
                <td><input type="text" name="txtUsername" placeholder="Enter Username"></td>
            </tr>
            <tr>
                <td><input type="text" name="txtPassword" placeholder="Enter Password"></td>
            </tr>
            <tr>
                <td>
                    <input name="btnLogin" type="submit" value="Login" />
                    <input name="btnRegister" type="submit" value="Register" />
                </td>
            </tr>
        </table>
    </form>
</body>

</html>