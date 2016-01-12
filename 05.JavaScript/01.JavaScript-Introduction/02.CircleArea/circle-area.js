function calcCircleArea(r) {
    var area = Math.PI * r * r;
    return area;
}

document.writeln('r = 7; area = ' + calcCircleArea(7) + "<br>");
document.writeln('r = 1.5; area = ' + calcCircleArea(1.5) + "<br>");
document.writeln('r = 20; area = ' + calcCircleArea(20) + "<br>");