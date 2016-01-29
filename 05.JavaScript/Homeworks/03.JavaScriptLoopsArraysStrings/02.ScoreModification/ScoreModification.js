function solve(arr) {
    var validScores = arr.filter(function(x) {
        return 0 <= x && x <= 400;
    });

    for(var i in validScores) {
        validScores[i] = Math.round(validScores[i] * 80) / 100
    }

    validScores.sort(function (x, y) {
        return x > y;
    });
    console.log(validScores);
}

solve([200, 120, 23, 67, 350, 420, 170, 212, 401, 615, -1]);
