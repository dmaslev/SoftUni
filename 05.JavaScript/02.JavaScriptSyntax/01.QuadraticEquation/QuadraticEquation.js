var a = prompt("enter value of a");
var b = prompt("enter value of b");
var c = prompt("enter value of c");
var d = b * b - 4 * a * c;

if (d < 0) {
    console.log("No real roots");
} else if (d === 0) {
    console.log("x = " + (-b / 2 * a));
} else {
    console.log("x1 = " + (-b - (Math.sqrt(d))) / (2 * a));
    console.log("x2 = " + (-b + (Math.sqrt(d))) / (2 * a));
}