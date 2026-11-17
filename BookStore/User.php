<?php
include("Config.php");
class User
{
    public $UserId;
    public $Name;
    public $UserName;
    public $Password;
    public $Email;
    public $Type;

    public function Login()
    {
        try {
            if (!empty($_POST['txtUsername']) && !empty($_POST['txtPassword'])) {
                $conn = Config::GetConnection();
                $query = "SELECT `Name`, `Password` FROM user WHERE Username=?";
                $stmt = $conn->prepare($query);
                $stmt->bindParam(1, $this->UserName, PDO::PARAM_STR);
                $stmt->execute();
                $row = $stmt->fetch();
                // the stored password is a password_hash() value
                if ($row && password_verify($this->Password, $row['Password'])) {
                    session_regenerate_id(true);
                    $_SESSION["Logged"] = "Logged";
                    header("location:ManageBook.php");
                    exit;
                } else {
                    echo "<script>alert('Invalid Username or Password')</script>";
                }
            } else {
                echo "<script>alert('Invalid Username or Password')</script>";
            }
        } catch (Exception $ex) {
            throw $ex;
        }
    }
}
