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
                $query = "SELECT `Name`
                    FROM user 
                    WHERE Username=? and Password=? ";
                $stmt = $conn->prepare($query);
                $stmt->bindParam(1, $this->UserName, PDO::PARAM_STR);
                $stmt->bindParam(2, $this->Password, PDO::PARAM_STR);
                $stmt->execute();
                $results = $stmt->fetchAll();
                $user = new User();
                if (isset($results[0])) {
                    $_SESSION["Logged"] = "Logged";
                    header("location:ManageBook.php");
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
