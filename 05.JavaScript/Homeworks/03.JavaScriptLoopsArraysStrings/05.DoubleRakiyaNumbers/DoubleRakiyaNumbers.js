function solve(arr) {
    var start = parseInt(arr[0]);
    var end = parseInt(arr[1]);

    console.log('<ul>');

    for (var i = start; i <= end; i++) {
        if (isDoubleRakiyaNum(i)) {
            console.log("<li><span class='rakiya'>" + i + "</span><a href=\"view.php?id=" + i + "\>View</a></li>")
        } else {
            console.log("<li><span class='num'>" + i + "</span></li>")
        }
    }
    console.log('</ul>');

    function isDoubleRakiyaNum(num) {
        var numStr = num.toString();
        var arr = [];
        for (var i = 0; i < numStr.length - 1; i++) {
            var current = numStr.substr(i, 2);
            if (arr[current]) {
                if(i - arr[current] >= 1 ) {
                    return true;
                }
            } else {
                arr[current] = i + 1;
            }
        }


        return false;
    }
}