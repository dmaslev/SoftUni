function Solve(arr) {
    var start = parseInt(arr[0]);
    var end = parseInt(arr[1]);
    console.log('<table>');
    console.log('<tr><th>Num</th><th>Square</th><th>Fib</th></tr>');
    var fibNumbers = findFibonacciNumbers(end);
    for (var i = start; i <= end; i++) {
        console.log('<tr><td>' + i + '</td><td>' + (i * i) + '</td><td>' + isFibonacci(i, fibNumbers) + '</td></tr>');
    }

    console.log('</table>');

    function isFibonacci(i, fibNumbers) {
        if (fibNumbers[i]) {
            return 'yes';
        } else {
            return 'no';
        }
    }

    function findFibonacciNumbers(end) {
        var first = 1;
        var second = 1;
        var third = first + second;
        var fibNumbers = [];
        fibNumbers[first] = true;
        fibNumbers[second] = true;

        while (third <= end) {
            fibNumbers[third] = true;

            first = second;
            second = third;
            third = first + second;
        }

        return fibNumbers;
    }
}