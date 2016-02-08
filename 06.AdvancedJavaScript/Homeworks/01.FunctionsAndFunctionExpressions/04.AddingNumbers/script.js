var add = (function () {
    var sum = 0;

    function inner(increment) {
        sum += increment;
        return add;
    }

    inner.toString = function () {
        return sum;
    }

    return inner;
})();

var addTwo = add(2);
console.log(addTwo.toString());
console.log(addTwo(3).toString());
console.log(addTwo(5).toString());