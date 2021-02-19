document.getElementById("download").addEventListener("click", download);

function convertToCSV(objArray) {
    var array = typeof objArray != "object" ? JSON.parse(objArray) : objArray;
    var str = "";

    for (var i = 0; i < array.length; i++) {
        var line = "";
        for (var index in array[i]) {
            if (line != "") line += ",";

            line += array[i][index];
        }

        str += line + "\r\n";
    }

    return str;
}

function exportCSVFile(headers, items, fileTitle) {
    if (headers) {
        items.unshift(headers);
    }

    // Convert Object to JSON
    var jsonObject = JSON.stringify(items);

    var csv = this.convertToCSV(jsonObject);

    var exportedFilenmae = fileTitle + ".csv" || "export.csv";

    var blob = new Blob([csv], { type: "text/csv;charset=utf-8;" });
    if (navigator.msSaveBlob) {
        // IE 10+
        navigator.msSaveBlob(blob, exportedFilenmae);
    } else {
        var link = document.createElement("a");
        if (link.download !== undefined) {
            // feature detection
            // Browsers that support HTML5 download attribute
            var url = URL.createObjectURL(blob);
            link.setAttribute("href", url);
            link.setAttribute("download", exportedFilenmae);
            link.style.visibility = "hidden";
            document.body.appendChild(link);
            link.click();
            document.body.removeChild(link);
        }
    }
}

function download() {
    var headers = {
        symptom: "Symptoms".replace(/,/g, ""),
        precovid: "Precovid",
        postcovid: "Postcovid",
        severity: "Severity"
    };

    itemsNotFormatted = [
        {
            symptom: "Activities",
            precovid: "4.5",
            postcovid: "6.8",
            severity: "5",
        },
        {
            symptom: "Anxiety",
            precovid: "2.3",
            postcovid: "4.6",
            severity: "3",
        },
        {
            symptom: "Breathlessness",
            precovid: "1.8",
            postcovid: "7.1",
            severity: "10",
        },
        {
            symptom: "Cognition",
            precovid: "2.5",
            postcovid: "4.",
            severity: "4",
        },
    ];

    var itemsFormatted = [];

    // format the data
    itemsNotFormatted.forEach((item) => {
        itemsFormatted.push({
            symptom: item.symptom.replace(/,/g, ""), // remove commas to avoid errors,
            precovid: item.precovid,
            postcovid: item.postcovid,
            severity: item.severity
        });
    });

    var fileTitle = "orders"; // or 'my-unique-title'

    exportCSVFile(headers, itemsFormatted, fileTitle); // call the exportCSVFile() function to process the JSON and trigger the download
}
