<?php
include("Config.php");
class Book
{
    public $Id;
    public $Title;
    public $Desctiption;
    public $Price;
    public $Category;
    public $CoverFront;
    public $CoverBack;
    public $ISBN;
    public $Author;
    public function ADD()
    {
        try {
            // $conn = new Config(); // if the function is only "public function" we need to create an object
            // $conn->GetConnection() // and use the object with an arrow.

            $conn = Config::GetConnection(); // if it is "public static function" you can use it with directly with two colons
            $query = "INSERT INTO `book`( `Title`, `Desctiption`, `Price`, `CoverFront`, `CoverBack`, `ISBN`, `Category`, `Author`)
                        VALUES (?,?,?,?,?,?,?,?)";
            $stmt = $conn->prepare($query);
            $stmt->bindParam(1, $this->Title, PDO::PARAM_STR);
            $stmt->bindParam(2, $this->Desctiption, PDO::PARAM_STR);
            $stmt->bindParam(3, $this->Price, PDO::PARAM_INT);
            $stmt->bindParam(4, $this->CoverFront, PDO::PARAM_STR);
            $stmt->bindParam(5, $this->CoverBack, PDO::PARAM_STR);
            $stmt->bindParam(6, $this->ISBN, PDO::PARAM_INT);
            $stmt->bindParam(7, $this->Category, PDO::PARAM_STR);
            $stmt->bindParam(8, $this->Author, PDO::PARAM_STR);
            $stmt->execute();
            return $conn->lastInsertId();
        } catch (Exception $ex) {
            throw $ex;
        }
    }

    public function UpdateCovers()
    {
        try {
            $conn = Config::GetConnection();
            $query = "UPDATE book SET CoverFront=?, CoverBack=? WHERE ID=?";
            $stmt = $conn->prepare($query);
            $stmt->bindParam(1, $this->CoverFront, PDO::PARAM_STR);
            $stmt->bindParam(2, $this->CoverBack, PDO::PARAM_STR);
            $stmt->bindParam(3, $this->Id, PDO::PARAM_INT);
            $stmt->execute();
        } catch (Exception $ex) {
            throw $ex;
        }
    }

    public function Delete()
    {
        try {
            $conn = Config::GetConnection();
            $query = "DELETE FROM book WHERE ID=?";
            $stmt = $conn->prepare($query);
            $stmt->bindParam(1, $this->Id, PDO::PARAM_INT);
            $stmt->execute();
        } catch (Exception $ex) {
            throw $ex;
        }
    }


    public function Update()
    {
        try {
            // $conn = new Config(); // if the function is only "public function" we need to create an object
            // $conn->GetConnection() // and use the object with an arrow.

            $conn = Config::GetConnection(); // if it is "public static function" you can use it with directly with two colons
            $query = "UPDATE `book` set  `Title`=?, `Desctiption`=?, `Price`=?, `CoverFront`=?, `CoverBack`=?, `ISBN`=?, `Category`=?, `Author`=? where id= ?";
            $stmt = $conn->prepare($query);
            $stmt->bindParam(1, $this->Title, PDO::PARAM_STR);
            $stmt->bindParam(2, $this->Desctiption, PDO::PARAM_STR);
            $stmt->bindParam(3, $this->Price, PDO::PARAM_INT);
            $stmt->bindParam(4, $this->CoverFront, PDO::PARAM_STR);
            $stmt->bindParam(5, $this->CoverBack, PDO::PARAM_STR);
            $stmt->bindParam(6, $this->ISBN, PDO::PARAM_INT);
            $stmt->bindParam(7, $this->Category, PDO::PARAM_STR);
            $stmt->bindParam(8, $this->Author, PDO::PARAM_STR);
            $stmt->bindParam(9, $this->Id, PDO::PARAM_STR);
            $stmt->execute();
        } catch (Exception $ex) {
            throw $ex;
        }
    }

    public function GetBooks()
    {
        try {
            $conn = Config::GetConnection();
            $query = "SELECT `id`, `Title`, `Desctiption`, `Price`, `CoverFront`, `CoverBack`, `ISBN`, `Category`, `Author` FROM book";
            $stmt = $conn->prepare($query);
            $stmt->execute();
            $results = $stmt->fetchAll();
            $books = array();
            foreach ($results as $item) {
                $book = new Book();
                $book->Id = $item['id'];
                $book->Title = $item['Title'];
                $book->Desctiption = $item['Desctiption'];
                $book->Price = $item['Price'];
                $book->CoverFront = $item['CoverFront'];
                $book->CoverBack = $item['CoverBack'];
                $book->ISBN = $item['ISBN'];
                $book->Category = $item['Category'];
                $book->Author = $item['Author'];
                array_push($books, $book);
            }
            return $books;
        } catch (Exception $ex) {
            throw $ex;
        }
    }


    public function GetBook()
    {
        try {
            $conn = Config::GetConnection();
            $query = "SELECT `id`, `Title`, `Desctiption`, `Price`, `CoverFront`, `CoverBack`, `ISBN`, `Category`, `Author` FROM book WHERE id=?";
            $stmt = $conn->prepare($query);
            $stmt->bindParam(1, $this->Id, PDO::PARAM_INT);
            $stmt->execute();
            $results = $stmt->fetchAll();
            $book = new Book();
            foreach ($results as $item) {
                $book->Id = $item['id'];
                $book->Title = $item['Title'];
                $book->Desctiption = $item['Desctiption'];
                $book->Price = $item['Price'];
                $book->CoverFront = $item['CoverFront'];
                $book->CoverBack = $item['CoverBack'];
                $book->ISBN = $item['ISBN'];
                $book->Category = $item['Category'];
                $book->Author = $item['Author'];
            }
            return $book;
        } catch (Exception $ex) {
            throw $ex;
        }
    }
}
