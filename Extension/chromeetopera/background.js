chrome.tabs.onUpdated.addListener((tabId, changeInfo, tab) => {
    if (changeInfo.status !== "complete") return;

    try {
        const url = new URL(tab.url);
        const site = url.hostname;

        fetch(`http://localhost:50000/credentials?site=${site}`)
            .then(res => {
                if (!res.ok) throw new Error("Pas d'identifiants");
                return res.json();
            })
            .then(creds => {
                chrome.scripting.executeScript({
                    target: { tabId: tabId },
                    func: autofillFields,
                    args: [creds.username, creds.password]
                });
            })
            .catch(err => {
                // Aucune entrée trouvée = normal dans 90% des sites
                console.log("Aucun identifiant pour ce site");
            });

    } catch (e) {
        console.log("URL non valide");
    }
});

function autofillFields(username, password) {
    // champs possibles
    const userFields = document.querySelectorAll("input[type='email'], input[type='text'], input[name*='user'], input[name*='login']");
    const passFields = document.querySelectorAll("input[type='password']");

    if (userFields.length > 0) userFields[0].value = username;
    if (passFields.length > 0) passFields[0].value = password;
}
