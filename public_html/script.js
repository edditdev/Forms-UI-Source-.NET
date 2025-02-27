document.addEventListener("DOMContentLoaded", () => {
    const loginForm = document.getElementById("login-form");
    const registerForm = document.getElementById("register-form");
    const showLoginButton = document.getElementById("show-login");
    const showRegisterButton = document.getElementById("show-register");
    const notification = document.getElementById("notification");

    const toggleForms = (showLogin) => {
        if (showLogin) {
            loginForm.classList.add("active");
            loginForm.classList.remove("hidden");
            registerForm.classList.remove("active");
            registerForm.classList.add("hidden");
            showLoginButton.classList.add("active");
            showRegisterButton.classList.remove("active");
        } else {
            registerForm.classList.add("active");
            registerForm.classList.remove("hidden");
            loginForm.classList.remove("active");
            loginForm.classList.add("hidden");
            showRegisterButton.classList.add("active");
            showLoginButton.classList.remove("active");
        }
    };

    showLoginButton.addEventListener("click", () => toggleForms(true));
    showRegisterButton.addEventListener("click", () => toggleForms(false));

    const showNotification = (message, isSuccess = true) => {
        notification.innerText = message;
        notification.style.background = isSuccess ? "green" : "red";
        notification.style.display = "block";
        setTimeout(() => {
            notification.style.display = "none";
        }, 5000);
    };

    loginForm.addEventListener("submit", (e) => {
        e.preventDefault();
        const formData = new FormData(loginForm);
        formData.append("action", "login");

        fetch("process.php", {
            method: "POST",
            body: formData,
        })
            .then((response) => response.text())
            .then((data) => {
                if (data === "Login successful!") {
                    showNotification(data);
                    setTimeout(() => {
                        window.location.href = "dash.php";
                    }, 1000);
                } else {
                    showNotification(data, false);
                }
            })
            .catch(() => showNotification("Wyst¹pi³ b³¹d. Spróbuj ponownie.", false));
    });

    registerForm.addEventListener("submit", (e) => {
        e.preventDefault();
        const formData = new FormData(registerForm);
        formData.append("action", "register");

        fetch("process.php", {
            method: "POST",
            body: formData,
        })
            .then((response) => response.text())
            .then((data) => {
                if (data === "Registration successful!") {
                    showNotification(data);
                    toggleForms(true);
                } else {
                    showNotification(data, false);
                }
            })
            .catch(() => showNotification("Wyst¹pi³ b³¹d. Spróbuj ponownie.", false));
    });
});
