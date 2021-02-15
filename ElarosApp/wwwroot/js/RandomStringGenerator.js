document.getElementById("GeneratedCode").addEventListener("click", CodeGenerator);

function CodeGenerator() {
    var randomcode = "";
    var omittedChars = [58, 59, 60, 61, 62, 63, 64, 91, 92, 93, 94, 95, 96];

    for (var i = 0; i < 5; i++)
    {
        var randomInt = Math.floor((Math.random() * 74) + 48);
        while (omittedChars.contains(randomInt)) {
            randomInt = Math.floor((Math.random() * 74) + 48);
        }
        randomCode += String.fromCharCode(randomInt);
    }
    document.getElementById("TextBoxRefCode").value = randomcode;
}

