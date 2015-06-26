//Important javascript that would otherwise break the internet if it didn't exist!

window.onload = function () {
    var clickToHonk = document.getElementById('honk');

    clickToHonk.onclick=function(){
        var honk = new Audio('audio/clownhonk.mp3');
        honk.play();
    }
}
