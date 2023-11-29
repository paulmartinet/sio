// Ajoutez ce script à votre fichier JavaScript
const progressCircles = document.querySelectorAll(".progress-circle");

progressCircles.forEach(circle => {
    const value = circle.getAttribute("data-value");
    const percentage = parseFloat(value) / 100;
    const circumference = 2 * Math.PI * 50;
    circle.style.strokeDasharray = `${circumference} ${circumference}`;
    circle.style.strokeDashoffset = `${circumference * (1 - percentage)}`;
});
