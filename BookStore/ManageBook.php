<?php
session_start();
include("Book.php");

// if (!isset($_SESSION["Logged"]))
//     header("location:Login.php");


if (isset($_POST["btnLogOut"])) {
    unset($_SESSION["Logged"]);
    header("location:login.php");
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

    // if ($id > 0) {
    //     echo '<script>alert("Book Added.")</script>';
    // } else {
    //     echo '<script>alert("Error in adding Book.")</script>';
    // }

    if ($id > 0) {
        $front = $_FILES["txtCoverF"]['name'];
        $back = $_FILES["txtCoverB"]['name'];
        $fileInfo = new SplFileInfo($front);
        $newFront = './BookCovers/' . $id . 'F.' . $fileInfo->getExtension();
        $fileInfo = new SplFileInfo($back);
        $newBack = './BookCovers/' . $id . 'B.' . $fileInfo->getExtension();

        // Upload Files to a Specific Location
        move_uploaded_file($_FILES["txtCoverF"]['tmp_name'], $newFront);
        move_uploaded_file($_FILES["txtCoverB"]['tmp_name'], $newBack);

        $book->Id = $id;
        $book->CoverFront = $newFront;
        $book->CoverBack = $newBack;

        // Update DB 
        $book->UpdateCovers();
        echo "<script>alert('book added')</script>";
    } else {
        '<script>alert("Failed to Add Book")</script>';
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

    if (isset($_FILES["txtCoverF"]) && isset($_FILES["txtCoverB"])) {
        $front = $_FILES["txtCoverF"]['name'];
        $back = $_FILES["txtCoverB"]['name'];
        $fileInfo = new SplFileInfo($front);
        $newFront = './BookCovers/' . $book->Id . 'F.' . $fileInfo->getExtension();
        $fileInfo = new SplFileInfo($back);
        $newBack = './BookCovers/' . $book->Id . 'B.' . $fileInfo->getExtension();

        // Upload Files to a Specific Location
        move_uploaded_file($_FILES["txtCoverF"]['tmp_name'], $newFront);
        move_uploaded_file($_FILES["txtCoverB"]['tmp_name'], $newBack);

        $book->CoverFront = $newFront;
        $book->CoverBack = $newBack;
    } elseif (isset($_FILES["txtCoverF"]) && !isset($_FILES["txtCoverB"])) {
        $front = $_FILES["txtCoverF"]['name'];
        $fileInfo = new SplFileInfo($front);
        $newFront = './BookCovers/' . $book->Id . 'F.' . $fileInfo->getExtension();

        // Upload Files to a Specific Location
        move_uploaded_file($_FILES["txtCoverF"]['tmp_name'], $newFront);

        $book->CoverFront = $newFront;
        $book->CoverBack = $_SESSION['bookE']->CoverBack;
    } elseif (!isset($_FILES["txtCoverF"]) && isset($_FILES["txtCoverB"])) {
        $back = $_FILES["txtCoverB"]['name'];
        $fileInfo = new SplFileInfo($back);
        $newBack = './BookCovers/' . $book->Id . 'B.' . $fileInfo->getExtension();

        // Upload Files to a Specific Location
        move_uploaded_file($_FILES["txtCoverB"]['tmp_name'], $newBack);

        $book->CoverBack = $newBack;
        $book->CoverFront = $_SESSION['bookE']->CoverFront;
    } else {
        $book->CoverFront = $_SESSION['bookE']->CoverFront;
        $book->CoverBack = $_SESSION['bookE']->CoverBack;
    }

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
                                                                                echo "$book->Id";
                                                                            } ?>"></td>
                </tr>
                <tr>
                    <td>Title</td>
                    <td><input type="text" name="txtTitle" required value="<?php if (isset($book)) {
                                                                                echo "$book->Title";
                                                                            } ?>"></td>
                </tr>
                <tr>
                    <td>Author</td>
                    <td><input type="text" name="txtAuthor" required value="<?php if (isset($book)) {
                                                                                echo "$book->Author";
                                                                            } ?>"></td>
                </tr>
                <tr>
                    <td> Category</td>
                    <td><input type="text" name="txtCat" required value="<?php if (isset($book)) {
                                                                                echo "$book->Category";
                                                                            } ?>">
                    </td>
                </tr>

                <tr>
                    <td>ISBN</td>
                    <td><input type="text" name="txtISBN" required value="<?php if (isset($book)) {
                                                                                echo "$book->ISBN";
                                                                            } ?>"></td>
                </tr>
                <tr>
                    <td>Description</td>
                    <td><textarea name="txtDes" cols="30" rows="5"><?php if (isset($book)) {
                                                                        echo "$book->Desctiption";
                                                                    } ?></textarea>
                    </td>
                </tr>
                <tr>
                    <td>Price</td>
                    <td><input type="number" name="txtPrice" required value="<?php if (isset($book)) {
                                                                                    echo "$book->Price";
                                                                                } ?>"></td>
                </tr>
                <tr>
                    <td>Front Cover</td>
                    <td>
                        <?php
                        if (isset($book)) {
                            echo '<img src="' . $book->CoverFront . '" width="100px" height="100px"/>';
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
                            echo '<img src="' . $book->CoverBack . '" width="100px" height="100px"/>';
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
                    <td>' . $b->Id . ' </td>
                    <td>' . $b->Title . ' </td>
                    <td><img src="' . $b->CoverFront . '" width="80px" height="80px" />
                        <img src="' . $b->CoverBack . '" width="80px" height="80px" />
                    </td>
                    <td>' . $b->Price . '</td>
                    <td>' . $b->Category . '</td>
                    <td>' . $b->Desctiption . '<br>
                    Author : ' . $b->Author . '<br>
                    ISBN : ' . $b->ISBN . '</td>
                    <td><button name="btnEdit" id="btnEdit" type="submit" value="' . $b->Id . '" onclick="LoadBook(' . $b->Id . ')">Edit</button></td>
                </tr>';
        }
        echo '</table> </form>';
        ?>
    </main>
</body>

</html>