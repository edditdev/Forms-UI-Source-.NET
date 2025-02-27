<?php
session_start();

$action = $_POST['action'];
$username = htmlspecialchars($_POST['username']);
$password = $_POST['password'];
$database_dir = 'database/';

if ($action === 'login') {
    $user_dir = $database_dir . $username;
    if (file_exists($user_dir)) {
        $stored_password = file_get_contents($user_dir . '/pass');
        if (password_verify($password, $stored_password)) {
            $_SESSION['username'] = $username;
            echo "Login successful!";
            exit;
        } else {
            echo "Invalid password.";
            exit;
        }
    } else {
        echo "User not found.";
        exit;
    }
} elseif ($action === 'register') {
    $user_dir = $database_dir . $username;
    if (!file_exists($user_dir)) {
        mkdir($user_dir);
        file_put_contents($user_dir . '/user', $username);
        file_put_contents($user_dir . '/pass', password_hash($password, PASSWORD_DEFAULT));
        echo "Registration successful!";
        exit;
    } else {
        echo "Username already exists.";
        exit;
    }
}
?>
