<?php
// Small helpers shared by the pages.

// Escape a value before it is written into a page.
function h($v)
{
    return htmlspecialchars((string)$v, ENT_QUOTES, 'UTF-8');
}

// Saves an uploaded book cover ($suffix is "F" for the front, "B" for the back) as BookCovers/<id><suffix>.<ext>
// and returns its path, or null when no real picture (jpg, png, gif or webp) was uploaded.
function saveCover($field, $id, $suffix)
{
    if (!isset($_FILES[$field]) || $_FILES[$field]['error'] !== UPLOAD_ERR_OK) {
        return null;
    }
    $info = @getimagesize($_FILES[$field]['tmp_name']);
    $types = array(IMAGETYPE_JPEG => 'jpg', IMAGETYPE_PNG => 'png', IMAGETYPE_GIF => 'gif', IMAGETYPE_WEBP => 'webp');
    if ($info === false || !isset($types[$info[2]])) {
        return null;
    }
    $path = './BookCovers/' . (int)$id . $suffix . '.' . $types[$info[2]];
    if (!move_uploaded_file($_FILES[$field]['tmp_name'], $path)) {
        return null;
    }
    return $path;
}
