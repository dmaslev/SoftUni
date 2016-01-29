function solve(input) {
    var index = input[0].indexOf('(');
    var str = input[0].substr(index + 1, input[0].length - index - 2);
    var number = parseInt(str) % 360;
    var matrix = [];
    for (var i = 1; i < input.length; i++) {
        matrix[i-1] = [];
        for (var j = 0; j < input[i].length; j++) {
            matrix[i-1][j] = input[i][j];
        }
    }
    while (number > 0 ) {

        matrix = rotate();
        number -=90;
    }

    var line = '';
    for (var i = 0; i < matrix.length; i++) {
        line = '';
        for (var j = 0; j < matrix[i].length; j++) {
            line += matrix[i][j] ? matrix[i][j] : ' ';
        }

        console.log(line);
    }

    function rotate () {
        var temp = [];
        for (var i = 0; i < matrix.length; i++) {
            for (var j = 0; j < matrix[i].length; j++) {
                if (!temp[j]) {
                   temp[j] = [] ;
                }

                temp[j][matrix.length - i - 1] = matrix[i][j];
            }
        }

        return temp;
    }
}

var arr = [ 'Rotate(270)', 'hello', 'softuni', 'exam'];
solve(arr);