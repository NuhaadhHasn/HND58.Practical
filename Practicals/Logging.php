<?php
session_start();
$msg = "";
if (isset($_POST["btnLog"])) {
    if ($_POST["txtEmail"] == "nuhaadh9991@gmail.com" && $_POST["txtPW"] == "nuhaadh") {
        session_regenerate_id(true);
        $_SESSION["un"] = "Nuhaadh";
        header("location:Home.php");
        exit;
    } else {
        $msg = "Check Your Email Or Password";
    }
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
        <ul style="list-style-type: none;">
            <li>Email</li>
            <li><input type="email" name="txtEmail" placeholder="Enter Your Email" required></li>
            <li>Password</li>
            <li><input type="password" name="txtPW" required></li>
            <li><input type="submit" value="login" name="btnLog"></li>
            <li>
                <?php
                echo $msg;
                ?>
            </li>
        </ul>
    </form>
</body>

</html>