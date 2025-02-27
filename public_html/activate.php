<?php
session_start();
if (!isset($_SESSION['username'])) {
    exit("Unauthorized.");
}

$key = trim($_POST['key']);
$file = "products/codes.txt";
$user_dir = "database/" . $_SESSION['username'];

if (!file_exists($file) || !in_array($key, file($file, FILE_IGNORE_NEW_LINES))) {
    exit("Invalid license key.");
}

file_put_contents("$user_dir/activated", $key);
$updated_keys = array_filter(file($file, FILE_IGNORE_NEW_LINES), fn($line) => $line !== $key);
file_put_contents($file, implode(PHP_EOL, $updated_keys));

exit("Activation successful");
?>
