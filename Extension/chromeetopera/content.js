function autofillFields(username, password) {

    console.log("🔐 Vaulty Autofill : injection en cours…");

    const userFields = document.querySelectorAll(
        "input[type='email'], input[type='text'], input[name*='user'], input[name*='login']"
    );
    const passFields = document.querySelectorAll("input[type='password']");

    if (userFields.length > 0) {
        userFields[0].value = username;
        userFields[0].dispatchEvent(new Event("input", { bubbles: true }));
    }

    if (passFields.length > 0) {
        passFields[0].value = password;
        passFields[0].dispatchEvent(new Event("input", { bubbles: true }));
    }

    console.log("✅ Champs remplis");
}

// Obligatoire : exporte la fonction pour background.js
window.autofillFields = autofillFields;
