<?php
include("Book.php");
$BookId = $_GET['id'];
$book = new Book();
$book->Id = $BookId;
$b = $book->GetBook();
echo json_encode($b);
