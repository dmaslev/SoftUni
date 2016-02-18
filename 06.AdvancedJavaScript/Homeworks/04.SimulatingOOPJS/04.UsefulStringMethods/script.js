String.prototype.startsWith = function (word) {
    var index = this.indexOf(word);

    return index === 0 ? true : false;
}

String.prototype.endsWith = function (word) {
    var index = this.lastIndexOf(word);
    var expected = this.length - word.length;

    return index === expected ? true : false;
}

String.prototype.left = function (count) {
    return this.substr(0, Math.min(this.length, count));
}

String.prototype.right = function (count) {
    return this.substr(Math.max(0, this.length - count), count);
}

String.prototype.padLeft = function (count, character) {
    var char = arguments[1]||' ';
    var count = arguments[0];
    return char.repeat(count) + this;
}

String.prototype.padRight = function (count, character) {
    var char = arguments[1]||' ';
    var count = arguments[0];
    return this + char.repeat(count);
}

String.prototype.repeat = function (count) {
    return Array(count+1).join(this);
}

var example = "This is an example string used only for demonstration purposes.";
//console.log(example.startsWith("This"));
//console.log(example.startsWith("this"));
//console.log(example.startsWith("other"));
//
//console.log(example.endsWith("poses."));
//console.log(example.endsWith("example"));
//console.log(example.startsWith("something else"));

//console.log(example.left(9));
//console.log(example.left(90));

console.log(example.right(9));
console.log(example.right(90));

// Combinations must also work
//var example = "abcdefgh";
//console.log(example.left(5).right(2));
//var hello = "hello";
//console.log(hello.padLeft(5));
//console.log(hello.padLeft(10));
//console.log(hello.padLeft(5, "."));
//console.log(hello.padLeft(10, "."));
//console.log(hello.padLeft(2, "."));
//var hello = "hello";
//console.log(hello.padRight(5));
//console.log(hello.padRight(10));
//console.log(hello.padRight(5, "."));
//console.log(hello.padRight(10, "."));
//console.log(hello.padRight(2, "."));
//var character = "*";
//console.log(character.repeat(5));
//console.log("~".repeat(3));
//console.log("*".repeat(5).padLeft(10, "-").padRight(15, "+"));




