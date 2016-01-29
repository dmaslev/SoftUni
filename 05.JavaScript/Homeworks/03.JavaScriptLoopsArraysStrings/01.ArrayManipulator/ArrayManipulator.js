function solve(arr) {
    var numbers = arr.filter(function(x) {
        return !isNaN(x);
    });

    numbers.sort(function(x, y) {
        return x < y;
    });
    var minNumber = Math.min.apply(null, numbers);
    var maxNumber = Math.max.apply(null, numbers);

    var count = 1;
    var num;
    var maxCount = 0;
    numbers.forEach(function(x, y) {
        if (x === y) {
            count++;
            if (count > maxCount) {
                num = x;
                maxCount = count;
            }
        } else {
            count = 1;
        }
    });

    console.log('Min number: ' + minNumber);
    console.log('Max number: ' + maxNumber);
    console.log('Most frequent number: ' + num);
    console.log(numbers);
}

solve(["Pesho", 2, "Gosho", 12, 2, "true", 9, undefined, 0, "Penka", { bunniesCount: 10 }, [10, 20, 30, 40]]);
