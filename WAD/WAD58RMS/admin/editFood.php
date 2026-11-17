<?php
session_start();
include("food.php");
requireLogin("AdminLogged", "../login.php");
$currentId = $_GET['editFood'] ?? null;

if (isset($_GET['editFood'])) {
    $food = new Food();
    $food->foodId = $currentId;
    $food = $food->GetFood();
}

if (isset($_POST["btnAddNewFood"])) {
    $food = new Food();
    $food->foodId = $currentId;
    $getFood = $food->GetFood();
    $food->foodId = $currentId;
    $food->foodName = $_POST["txtRegisterFoodName"];
    $food->foodPrice = $_POST["txtRegisterFoodPrice"];
    $food->foodCategory = $_POST["txtRegisterFoodCategory"];
    $food->offerAvailable = $_POST["txtRegisterFoodOffer"];
    $food->foodDescription = $_POST["txtRegisterFoodDescription"];
    $food->foodImage = saveUploadedImage("txtRegisterFoodImage", "../img") ?? $getFood->foodImage;

    $food->UpdateFood();
}

?>

<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Edit Food</title>
    <link rel="stylesheet" href="../css/all.min.css">
    <link rel="stylesheet" href="../css/bootstrap.min.css">
    <link rel="stylesheet" href="../css/navBar.css" />
    <link rel="stylesheet" href="../css/background.css" />
    <link rel="stylesheet" href="../css/form.css" />
    <link rel="stylesheet" href="../css/formOverlay.css" />
    <link rel="stylesheet" href="../css/modal.css" />
    <link rel="stylesheet" href="../css/table.css" />
    <link rel="stylesheet" href="../css/test.css" />

</head>

<body>
    <?php
    include('navBar.php');


    ?>
    <div class="clearfix"></div>
    <div>
        <div class="ocean">
            <div class="wave"></div>
            <div class="wave"></div>
        </div>


        <?php
        include("addFood.php")
        ?>
    </div>
</body>

</html>