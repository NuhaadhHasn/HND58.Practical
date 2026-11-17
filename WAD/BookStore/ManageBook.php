<?php
session_start();
include("Book.php");
include("helpers.php");

if (!isset($_SESSION["Logged"])) {
    header("location:Login.php");
    exit;
}

if (isset($_POST["btnLogOut"])) {
    unset($_SESSION["Logged"]);
    header("location:Login.php");
    exit;
}

if (isset($_POST["btnAdd"])) {
    $book = new Book();
    $book->Title = $_POST["txtTitle"];
    $book->Desctiption = $_POST["txtDes"];
    $book->Price = $_POST["txtPrice"];
    $book->Category = $_POST["txtCat"];
    $book->CoverFront = "defaultF.jpg";
    $book->CoverBack = "defaultB.jpg";
    $book->ISBN = $_POST["txtISBN"];
    $book->Author = $_POST["txtAuthor"];
    $id = $book->ADD();

    if ($id > 0) {
        // only real pictures are saved (see saveCover in helpers.php)
        $newFront = saveCover("txtCoverF", $id, "F");
        $newBack = saveCover("txtCoverB", $id, "B");
        if ($newFront !== null || $newBack !== null) {
            $book->Id = $id;
            if ($newFront !== null) {
                $book->CoverFront = $newFront;
            }
            if ($newBack !== null) {
                $book->CoverBack = $newBack;
            }
            $book->UpdateCovers();
        }
        echo "<script>alert('book added')</script>";
    } else {
        echo '<script>alert("Failed to Add Book")</script>';
    }
} elseif (isset($_POST['btnEdit'])) {
    $book = new Book();
    $book->Id = $_POST['btnEdit'];
    $book = $book->GetBook();
    $_SESSION["bookE"] = $book;
} elseif (isset($_POST['btnUpdate'])) {
    $book = new Book();
    $book->Id = $_POST["txtID"];
    $book->Title = $_POST["txtTitle"];
    $book->Desctiption = $_POST["txtDes"];
    $book->Price = $_POST["txtPrice"];
    $book->Category = $_POST["txtCat"];
    $book->ISBN = $_POST["txtISBN"];
    $book->Author = $_POST["txtAuthor"];

    // keep the covers the book already has unless a new picture was chosen
    $old = new Book();
    $old->Id = $book->Id;
    $old = $old->GetBook();
    $newFront = saveCover("txtCoverF", $book->Id, "F");
    $newBack = saveCover("txtCoverB", $book->Id, "B");
    $book->CoverFront = $newFront !== null ? $newFront : $old->CoverFront;
    $book->CoverBack = $newBack !== null ? $newBack : $old->CoverBack;

    $book->Update();
} elseif (isset($_POST["btnDelete"])) {
    $book = new Book();
    $book->Id = $_POST['txtID'];
    $book->Delete();
    $book = null;
}
?>

<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>ManageBook</title>
    <link rel="stylesheet" href="Style/admin.css">
    <script>
        function LoadBook(id) {
            try {
                var httpxml = new XMLHttpRequest();
                var url = "LoadBook.php?id=" + id;
                httpxml.onreadystatechange = check;
                httpxml.open("GET", url, true);
                httpxml.send(null);
            } catch (error) {}

            function check() {
                if (httpxml.readyState == 4) {
                    var book = JSON.parse(httpxml.responseText);
                    alert(book["Id"]);
                }
            }
        }
    </script>
</head>

<body>
    <?php
    include("top.php")
    ?>
    <aside>

        <form method="post" enctype="multipart/form-data" name="bookdata">
            <table>
                <tr>
                    <td>Book ID</td>
                    <td><input type="number" readonly name="txtID" value="<?php if (isset($book)) {
                                                                                echo h($book->Id);
                                                                            } ?>"></td>
                </tr>
                <tr>
                    <td>Title</td>
                    <td><input type="text" name="txtTitle" required value="<?php if (isset($book)) {
                                                                                echo h($book->Title);
                                                                            } ?>"></td>
                </tr>
                <tr>
                    <td>Author</td>
                    <td><input type="text" name="txtAuthor" required value="<?php if (isset($book)) {
                                                                                echo h($book->Author);
                                                                            } ?>"></td>
                </tr>
                <tr>
                    <td> Category</td>
                    <td><input type="text" name="txtCat" required value="<?php if (isset($book)) {
                                                                                echo h($book->Category);
                                                                            } ?>">
                    </td>
                </tr>

                <tr>
                    <td>ISBN</td>
                    <td><input type="text" name="txtISBN" required value="<?php if (isset($book)) {
                                                                                echo h($book->ISBN);
                                                                            } ?>"></td>
                </tr>
                <tr>
                    <td>Description</td>
                    <td><textarea name="txtDes" cols="30" rows="5"><?php if (isset($book)) {
                                                                        echo h($book->Desctiption);
                                                                    } ?></textarea>
                    </td>
                </tr>
                <tr>
                    <td>Price</td>
                    <td><input type="number" name="txtPrice" required value="<?php if (isset($book)) {
                                                                                    echo h($book->Price);
                                                                                } ?>"></td>
                </tr>
                <tr>
                    <td>Front Cover</td>
                    <td>
                        <?php
                        if (isset($book)) {
                            echo '<img src="' . h($book->CoverFront) . '" width="100px" height="100px"/>';
                        }
                        ?>
                        <input type="file" name="txtCoverF" id="">
                    </td>
                </tr>
                <tr>
                    <td>Back Cover</td>
                    <td>
                        <?php
                        if (isset($book)) {
                            echo '<img src="' . h($book->CoverBack) . '" width="100px" height="100px"/>';
                        }
                        ?>
                        <input type="file" name="txtCoverB" id="">
                    </td>
                </tr>
                <tr>
                    <td></td>
                    <td>
                        <input type="submit" value="Add Book" name="btnAdd">
                        <input type="submit" value="Update Book" name="btnUpdate">
                        <input type="submit" value="Delete Book" name="btnDelete">
                        <input type="submit" value="Log Out" name="btnLogOut">
                    </td>
                </tr>
                <tr>
                    <td></td>
                    <td></td>
                </tr>
            </table>
        </form>
    </aside>
    <main>
        <?php
        $book = new Book();
        $books = $book->GetBooks();

        echo '<table>';
        echo '<form method="post">';
        echo '<tr>
                <th> ID</th>
                <th> Title</th>
                <th> Cover</th>
                <th> Price</th>
                <th> Category</th>
                <th> Description</th>
                <th> Edit</th>
            </tr>';
        foreach ($books as $b) {
            echo '<tr>
                    <td>' . h($b->Id) . ' </td>
                    <td>' . h($b->Title) . ' </td>
                    <td><img src="' . h($b->CoverFront) . '" width="80px" height="80px" />
                        <img src="' . h($b->CoverBack) . '" width="80px" height="80px" />
                    </td>
                    <td>' . h($b->Price) . '</td>
                    <td>' . h($b->Category) . '</td>
                    <td>' . h($b->Desctiption) . '<br>
                    Author : ' . h($b->Author) . '<br>
                    ISBN : ' . h($b->ISBN) . '</td>
                    <td><button name="btnEdit" id="btnEdit" type="submit" value="' . h($b->Id) . '">Edit</button></td>
                </tr>';
        }
        echo '</table> </form>';
        ?>
    </main>
</body>

</html>