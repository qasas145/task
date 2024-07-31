document.addEventListener('DOMContentLoaded', function () {
    const body = document.body;
    let hue = 0;

    function animateBackground() {
        hue = (hue + 1) % 360;
        body.style.background = `linear-gradient(to right, hsl(${hue}, 60%, 60%), hsl(${(hue + 60) % 360}, 60%, 60%))`;
        requestAnimationFrame(animateBackground);
    }

    animateBackground();
});
