<?php
session_start();
if (!isset($_SESSION["Logged"])) {
    http_response_code(403);
    exit;
}
include("Book.php");
$BookId = $_GET['id'];
$book = new Book();
$book->Id = $BookId;
$b = $book->GetBook();
echo json_encode($b);
