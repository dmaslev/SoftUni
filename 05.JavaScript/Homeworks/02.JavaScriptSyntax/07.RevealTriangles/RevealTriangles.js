function solve(arr) {
    var result = [];
    for (var i = 0; i < arr.length; i++) {
        result[i] = arr[i].split('');
    }

    for (var i = 0; i < arr.length - 1; i++) {
        if (result[i][0] !== '*') {
            result[i][0] = arr[i][0];
        }
        for (var j = 1; j < arr[i].length; j++) {
            var currentChar = arr[i][j];
            if (currentChar === arr[i + 1][j - 1] && currentChar === arr[i + 1][j] && currentChar === arr[i + 1][j + 1]) {
                result[i][j] = '*';
                result[i+1][j] = '*';
                result[i+1][j - 1] = '*';
                result[i+1][j + 1] = '*';
            }
        }
    }

    for (var i = 0; i < arr.length; i++) {
        console.log(result[i].join(''));
    }
}