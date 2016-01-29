function solve (input) {
    var carrots = 0;
    var cabage = 0;
    var lettuce = 0;
    var turnip = 0;
    var hits = 0;
    var result = [];
    var directions = input[0].split( /, /);
    var matrix = [];
    for (var i = 1; i < input.length; i++) {
        var temp = input[i].split(', ');
        matrix.push(temp);
    }

    var row = 0;
    var col = 0;
    for (var i = 0; i < directions.length; i++) {
        var direct = directions[i];
        if (direct === 'right') {
            if (matrix[row].length - 1 > col ) {
                col++;
            } else {
                hits++;
                continue;
            }
        } else if (direct === 'left') {
            if ( matrix[row].length > 1) {
                col--;
            } else {
                hits++;
                continue;
            }
        } else if (direct === 'up') {
            if (row > 1) {
                row--;
            } else {
                hits++;
                continue;
            }
        } else if (direct === 'down') {
            if (matrix.length - 1 > row) {
                row++;
            } else {
                hits++;
                continue;
            }
        }

        var cell = matrix[row][col];
        while (cell.indexOf('{!}') != -1 ) {
            carrots++;
            cell =  cell.replace('{!}', '@');
        }
        while (cell.indexOf('{&}') != -1 ) {
            lettuce++;
            cell = cell.replace('{&}', '@');
        }
        while (cell.indexOf('{*}') != -1 ) {
            cabage++;
            cell = cell.replace('{*}', '@');
        }
        while (cell.indexOf('{#}') != -1 ) {
            turnip++;
            cell = cell.replace('{#}', '@');
        }

        result.push(cell);
    }

    console.log('{"&":' + lettuce + ',"*":' + cabage + ',"#":' + turnip + ',"!":' + carrots + ',"wall hits":' + hits + '}');
    if (result.length > 0) {
        console.log(result.join('|'))
    } else {
        console.log('no');
    }
}

var arr = ['right, up, up, down', 'asdf, as{#}aj{g}dasd, kjldk{}fdffd, jdflk{#}jdfj', 'tr{X}yrty, zxx{*}zxc, mncvnvcn, popipoip', 'poiopipo, nmf{X}d{X}ei, mzoijwq, omcxzne'];
arr = ['right, right, down, left, left, down, right, right, down, left', 'qwekjs, asd{#}a, mxz{#}{*}',
'qwekjs, asd{#}a, xnc{&}a',
'qwekjs, asd{#}a, xnc{&}a',
'qwekjs, asd{#}a, xnc{&}a' ];
solve(arr);

