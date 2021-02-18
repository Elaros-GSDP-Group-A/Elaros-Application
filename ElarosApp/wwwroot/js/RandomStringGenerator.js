document.getElementById("GeneratedCode").addEventListener("click", CodeGenerator);
document.getElementById("ClipboardCopy").addEventListener("click", CopyCode);
document.getElementById("SendMail").addEventListener("click", SendEmail);

function CodeGenerator() {
    var code = "";
    var min = 48;
    var max = 123;
    for (var i = 0; i < 5; i++) {
        code += NumberCode(min, max);
    }
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

function SendEmail() {
    var code = document.getElementById("TextboxRefCode").value;
    var url = "";
    var addr = document.getElementById("staticEmail").value;
    if (code == null || code == "") {
        alert("Please Generate a Code First");
    }
    else if ((addr == "" || addr == null) || ValidateEmail(addr) == false) {
        alert("Please Enter a Valid Email");
    }
    else {
        url = "mailto:" + addr + "?subject=NHS%20Long%20Covid%20Questionnaire%20Referral%20Code&body=Please%20See%20Your%20Attached%20Referral%20Code%20" + code;
        window.location.href = url;
    }
}

function ValidateEmail(addr) {
    const re = /\S+@\S+\.\S+/;
    return re.test(addr);
}
