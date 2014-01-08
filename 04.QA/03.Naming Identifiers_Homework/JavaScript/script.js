function onButtonClick(event, arguments) {
    var windowObj = window;
    var browserName = windowObj.navigator.appCodeName;
    var isMozilla = (browserName === "Mozilla");

    if (isMozilla) {
        alert("Yes");
    }
    else {
        alert("No");
    }
}

var button = document.getElementById("button");
button.onclick = onButtonClick;

