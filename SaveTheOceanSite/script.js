var texts = [
    "Clean Water. Healthy Life.",
    "Our Water. Our Future. Ours to Protect.",
    "Water Pollution ain't cool so don't be a fool.",
    "Pollution free, what the world wants to be.",
    "Destroy water, you destroy life.",
    "Stop the pollution quick don't make the water sick.",
    "Pollution - If You Don't Kill It, It Will Kill You.",
    "Keep Our Oceans Fairly Blue.",
]
var pos = 0;
var textIdx = Math.floor(Math.random() * (texts.length - 1));
var displayed = "";
var printTextTime = 150;

$('#document').ready(function(){
    printText();
})

function printText() {
    console.log(texts[textIdx]);
    if(pos < texts[textIdx].length) {
        displayed += texts[textIdx][pos];
        $("#message").html(displayed);
        pos++;

        setTimeout(printText, printTextTime);
    } else {
        setTimeout(clearText, 800);
    }
}

function clearText() {
    if(pos > -1) {
        displayed = displayed.substr(0, pos--);
        $("#message").html(displayed);
        setTimeout(clearText, 50);
    } else {    
        textIdx = Math.floor(Math.random() * (texts.length - 1));
        pos = 0;
        setTimeout(printText, printTextTime);
    }
}