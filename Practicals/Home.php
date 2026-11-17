<?php
session_start();
if (!isset($_SESSION["un"]))
    header("location:Logging.php");
if (isset($_POST["btnLogOut"])) {
    unset($_SESSION["un"]);
    header("location:logging.php");
}
?>

<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Home</title>
</head>

<body>
    <h1>Welcome <?php echo $_SESSION["un"] ?></h1>
    <form method="post">
        <input type="submit" value="Logout" name="btnLogOut">
    </form>
</body>

</html>