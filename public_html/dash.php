<?php
session_start();
if (!isset($_SESSION['username'])) {
    header("Location: index.html");
    exit;
}
$username = $_SESSION['username'];

// Check if product is activated
$activated_file = "database/{$username}/activated";
$is_activated = file_exists($activated_file);

// Get invite code from file
$invite_file = "database/{$username}/inv";
$invite_code = file_exists($invite_file) ? trim(file_get_contents($invite_file)) : "Not generated";
// Mask half of the invite code
$invite_length = strlen($invite_code);
$half_length = ceil($invite_length / 2);
$masked_invite = substr($invite_code, 0, $half_length) . str_repeat('*', $invite_length - $half_length);

// Handle license activation
$activation_result = '';
if ($_SERVER['REQUEST_METHOD'] === 'POST' && isset($_POST['license'])) {
    $license = trim($_POST['license']);
    $codes_file = 'products/codes.txt';
    
    if (file_exists($codes_file)) {
        $codes = file($codes_file, FILE_IGNORE_NEW_LINES | FILE_SKIP_EMPTY_LINES);
        $found_key = array_search($license, $codes);
        
        if ($found_key !== false) {
            if (!is_dir("database/{$username}")) {
                mkdir("database/{$username}", 0777, true);
            }
            file_put_contents($activated_file, "Email Bomber activated on " . date('Y-m-d H:i:s'));
            unset($codes[$found_key]);
            file_put_contents($codes_file, implode("\n", $codes) . "\n");
            $activation_result = 'success';
        } else {
            $activation_result = 'error';
        }
    } else {
        $activation_result = 'error';
    }
}
?>

<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
        
    <!-- Title -->
    <title>mailrip.fun - panel</title>

    <!-- Meta Description for SEO -->
    <meta name="description" content="mailrip.fun - Unleashing the ultimate email bomber experience. Lightning-fast delivery, customizable content, and relentless performance. Your emails, our expertise.">

    <!-- Keywords for SEO -->
    <meta name="keywords" content="email bomber, email spammer, bomber 2025, free email spam, spam email free, email flooder, mail spammer, spam tool, email blast, spam generator, email flodder, mail bomber free, spam software, fast email spam, email spam tool">

    <!-- Author -->
    <meta name="author" content="mailrip.fun">

    <!-- Robots -->
    <meta name="robots" content="index, follow">

    <!-- Open Graph (OG) Tags for Social Media -->
    <meta property="og:title" content="mailrip.fun - Ultimate Email Bomber Experience">
    <meta property="og:description" content="Lightning-fast email bomber with innovative features and unmatched power. Customize your spam, flood inboxes, and dominate with zero limits.">
    <meta property="og:image" content="https://mailrip.fun/seo.png">
    <meta property="og:url" content="https://mailrip.fun">
    <meta property="og:type" content="website">

    <!-- Twitter Card Tags -->
    <meta name="twitter:card" content="summary_large_image">
    <meta name="twitter:title" content="mailrip.fun - Lightning-Fast Email Bomber 2025">
    <meta name="twitter:description" content="Unleash the ultimate email spammer: fast, powerful, and limitless. Your emails, our expertise.">
    <meta name="twitter:image" content="https://mailrip.fun/seo.png">

    <!-- Favicon -->
    <link rel="icon" href="/favicon.ico" type="image/x-icon">
    <style>
        /* Ogólne ustawienia */
        body {
            background: linear-gradient(135deg, #141e30, #243b55);
            color: #fff;
            font-family: 'Arial', sans-serif;
            margin: 0;
            display: flex;
            justify-content: center;
            align-items: center;
            height: 100vh;
            overflow: hidden;
            position: relative;
        }

        /* Vector network animation from external SVG */
        body::before {
            content: '';
            position: absolute;
            top: 0;
            left: 0;
            width: 100%;
            height: 100%;
            background: url('/bg.svg') repeat;
            background-size: 100px 100px; /* Adjust based on your SVG size */
            animation: networkMove 6s linear infinite;
            z-index: -1;
            opacity: 0.1; /* Adjust opacity as needed */
        }

        @keyframes networkMove {
            0% { background-position: 0 0; }
            100% { background-position: 100px 100px; } /* Matches background-size */
        }

        /* Kontener główny */
        .main-container {
            text-align: center;
            width: 100%;
            max-width: 900px;
            padding: 20px;
            display: flex;
            flex-direction: column;
            gap: 20px;
            position: relative;
            z-index: 1;
        }

        /* Logo */
        .logo {
            font-size: 3rem;
            text-transform: uppercase;
            font-weight: bold;
            letter-spacing: 2px;
            display: flex;
            justify-content: center;
            align-items: center;
            margin: 0;
        }

        .bom {
            color: crimson;
        }

        .ber {
            color: white;
            animation: glow 2s infinite alternate;
        }

        /* Animacja logo */
        @keyframes glow {
            0% { text-shadow: 0 0 10px crimson; }
            100% { text-shadow: 0 0 20px crimson; }
        }

        /* Powiadomienia */
        #notification {
            position: fixed;
            top: 20px;
            left: 50%;
            transform: translateX(-50%);
            padding: 10px 20px;
            border-radius: 6px;
            display: none;
            opacity: 0;
            transition: opacity 0.5s ease;
            z-index: 1000;
        }

        #notification.success {
            background: rgba(0, 255, 0, 0.2);
            border: 1px solid #00ff00;
            color: #fff;
        }

        #notification.error {
            background: rgba(255, 0, 0, 0.2);
            border: 1px solid #ff0000;
            color: #fff;
        }

        /* Custom dashboard styles */
        .header-section {
            background: rgba(255, 255, 255, 0.05);
            padding: 20px;
            border-radius: 12px;
            box-shadow: 0 8px 15px rgba(0, 0, 0, 0.3);
            height: 100px;
            display: flex;
            align-items: center;
            justify-content: center;
        }

        .content-area {
            display: flex;
            flex-wrap: wrap;
            gap: 20px;
        }

        .profile-panel, .action-panel {
            flex: 1;
            min-width: 300px;
            background: rgba(255, 255, 255, 0.1);
            padding: 20px;
            border-radius: 12px;
            box-shadow: 0 8px 15px rgba(0, 0, 0, 0.3);
        }

        .profile-panel h3, .action-panel h3 {
            margin-top: 0;
            color: crimson;
        }

        .welcome-text {
            margin: 15px 0;
            font-size: 1.4rem;
            font-weight: bold;
            color: #fff;
            text-shadow: 0 0 5px rgba(220, 20, 60, 0.5);
        }

        .invite-text {
            font-size: 0.9rem;
            color: rgba(255, 255, 255, 0.7);
            font-style: italic;
            margin: 10px 0;
        }

        .invite-text strong {
            color: #fff;
            font-style: normal;
        }

        .product {
            background-color: rgba(255, 255, 255, 0.1);
            padding: 20px;
            margin-bottom: 10px;
            border-radius: 10px;
            box-shadow: 0px 3px 10px rgba(0, 0, 0, 0.3);
        }

        .active {
            color: green;
        }

        .btn {
            background-color: crimson;
            padding: 10px 20px;
            color: white;
            border: none;
            border-radius: 5px;
            cursor: pointer;
            font-size: 16px;
            transition: background-color 0.3s ease;
        }

        .btn:hover {
            background-color: darkred;
        }

        input {
            width: 85%;
            margin: 10px 0;
            padding: 10px;
            border: none;
            border-radius: 6px;
            background: rgba(255, 255, 255, 0.2);
            color: #fff;
            font-size: 1rem;
        }

        input::placeholder {
            color: rgba(255, 255, 255, 0.6);
        }

        .logout-btn {
            width: auto;
            padding: 8px 16px;
            margin-top: 15px;
            background-color: crimson;
            color: white;
            border: none;
            border-radius: 6px;
            text-decoration: none;
            font-size: 1rem;
            font-weight: bold;
            transition: background-color 0.3s ease;
        }

        .logout-btn:hover {
            background-color: darkred;
        }

        footer {
            text-align: center;
            color: rgba(255, 255, 255, 0.7);
            font-size: 0.9rem;
            margin-top: 20px;
        }

        /* Responsywność */
        @media (max-width: 768px) {
            .main-container {
                width: 90%;
            }
            .logo {
                font-size: 2rem;
            }
            .content-area {
                flex-direction: column;
            }
            .header-section {
                height: 80px;
            }
        }
    </style>
</head>
<body>
    <div class="main-container">
        <div class="header-section">
            <div class="logo">
                <span class="bom">mailrip</span><span class="ber">.fun</span>
            </div>
        </div>

        <div id="notification"></div>

        <div class="content-area">
            <!-- Profile Panel -->
            <div class="profile-panel">
                <h3>User Profile</h3>
                <p class="welcome-text">Welcome, <?php echo htmlspecialchars($username); ?>!</p>
                <p class="invite-text"><strong>Invite Code:</strong> <?php echo htmlspecialchars($masked_invite); ?></p>
                <a href="logout.php" class="logout-btn">Logout</a>
            </div>

            <!-- Action Panel (Activation/Product) -->
            <div class="action-panel">
                <?php if ($is_activated): ?>
                    <h3>Your Products</h3>
                    <div class="product">
                        <h4>Email Bomber</h4>
                        <p>Status: <span class="active">Activated</span></p>
                        <button class="btn" onclick="window.location.href='download.php'">Download</button>
                    </div>
                <?php else: ?>
                    <h3>Activate Product</h3>
                    <form id="activation-form" method="POST">
                        <input type="text" name="license" placeholder="Enter license key" required>
                        <button type="submit" class="btn">Activate</button>
                    </form>
                <?php endif; ?>
            </div>
        </div>

        <footer>mailrip.fun 2025</footer>
    </div>

    <script>
        // Notification function
        function showNotification(message, type) {
            const notification = document.getElementById('notification');
            notification.textContent = message;
            notification.className = type; // Sets 'success' or 'error'
            notification.style.display = 'block';
            notification.style.opacity = '1';

            // Hide after 3 seconds
            setTimeout(() => {
                notification.style.opacity = '0';
                setTimeout(() => {
                    notification.style.display = 'none';
                }, 500);
            }, 3000);
        }

        // Handle form submission
        document.addEventListener('DOMContentLoaded', function() {
            const form = document.getElementById('activation-form');
            <?php if ($activation_result): ?>
                <?php if ($activation_result === 'success'): ?>
                    showNotification('License activated successfully!', 'success');
                    setTimeout(() => location.reload(), 1000); // Reload after 1s to show product
                <?php else: ?>
                    showNotification('Invalid license key!', 'error');
                <?php endif; ?>
            <?php endif; ?>

            if (form) {
                form.addEventListener('submit', function(e) {
                    // Form submission handled via PHP reload
                });
            }
        });
    </script>
</body>
</html>