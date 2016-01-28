function solve (input) {
    var result = [];


    for (var i = 2; i < input.length - 1; i++) {
        var line = input[i];
        var regex = /<\/td><td>([0-9.]+)/g;
        var match = regex.exec(line);
        var price = Number(match[1]);
        result.push({ price: price, line: line});
    }

    result.sort(function(a, b) {
        return a.price - b.price;
    });

    console.log(input[0]);
    console.log(input[1]);

    for (var i in result) {
        console.log(result[i].line);
    }

    console.log(input[input.length-1]);
}

var arr =  [ '<table>',
    '<tr><th>Product</th><th>Price</th><th>Votes</th></tr>',
    '<tr><td>Vodka Finlandia 1 l</td><td>19.35</td><td>+12</td></tr>',
    '<tr><td>Ariana Radler 0.5 l</td><td>1.19</td><td>+33</td></tr>',
    '<tr><td>Laptop HP 250 G2</td><td>629</td><td>+1</td></tr>',
    '<tr><td>Kamenitza Grapefruit 1 l</td><td>1.85</td><td>+7</td></tr>',
    '<tr><td>Cofee Davidoff 250 gr.</td><td>11.99</td><td>+11</td></tr>',
    '</table>' ];
solve(arr);
