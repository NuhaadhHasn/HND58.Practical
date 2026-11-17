<?php
// Small helpers shared by the pages (loaded from config.php).

// Escape a value before it is written into a page.
function e($value)
{
    return htmlspecialchars((string)$value, ENT_QUOTES, 'UTF-8');
}

// Stop the page for a visitor who is not logged in with the given session flag.
// header() alone does not stop the script, so exit is needed.
function requireLogin($flag, $redirect)
{
    if (!isset($_SESSION[$flag])) {
        header("location:" . $redirect);
        exit;
    }
}

// Save an uploaded picture into $dir and return its stored file name,
// or null when nothing valid was uploaded (not a picture, wrong type, upload error).
function saveUploadedImage($field, $dir)
{
    if (empty($_FILES[$field]["name"]) || $_FILES[$field]["error"] !== UPLOAD_ERR_OK) {
        return null;
    }
    $ext = strtolower(pathinfo($_FILES[$field]["name"], PATHINFO_EXTENSION));
    if (!in_array($ext, ["jpg", "jpeg", "png", "gif", "webp"], true)) {
        return null;
    }
    if (@getimagesize($_FILES[$field]["tmp_name"]) === false) {
        return null;
    }
    $name = bin2hex(random_bytes(8)) . "." . $ext;
    if (!move_uploaded_file($_FILES[$field]["tmp_name"], rtrim($dir, "/") . "/" . $name)) {
        return null;
    }
    return $name;
}
