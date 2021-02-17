document.getElementById("GeneratedCode").addEventListener("click", CodeGenerator);
document.getElementById("ClipboardCopy").addEventListener("click", CopyCode);

function CodeGenerator() {
    var code = "";
    var min = 48;
    var max = 123;
    for (var i = 0; i < 5; i++) {
        code += NumberCode(min, max);
    }
    console.log(code);
    document.getElementById("TextboxRefCode").value = code;
}

function NumberCode(min, max) {

    var exclusionSet = [58, 59, 60, 61, 62, 63, 64, 91, 92, 93, 94, 95, 96]
    do {
        var numCode = Math.floor(Math.random() * (max - min) + min);
    } while (exclusionSet.includes(numCode));
    return String.fromCharCode(numCode);
}

function CopyCode() {
    var code = document.getElementById("TextboxRefCode");
    code.select();
    document.execCommand("copy");
    alert("Text has been Copied To Clipboard");
}
