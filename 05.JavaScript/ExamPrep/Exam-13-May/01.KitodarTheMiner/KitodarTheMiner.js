function solve(input) {
    var silver = 0;
    var gold = 0;
    var diamonds = 0;
    for (var i = 0; i < input.length; i++) {
        var line = input[i].trim().replace(':', ' : ');
        var current = line.split(/\s+/);
        if (current[0] == 'mine') {
            var index = current.indexOf('-');
            var ore = current[index + 1];
            var quantity = current[index + 3];
            if(current[index + 2 ] == ':') {
                switch (ore) {
                    case 'silver':
                        silver += Number(quantity);
                        break;
                    case 'gold':
                        gold += Number(quantity);
                        break;
                    case 'diamonds':
                        diamonds += Number(quantity);
                        break;
                }
            }
        }
    }

    console.log('*Silver: ' + silver);
    console.log('*Gold: ' + gold);
    console.log('*Diamonds: ' + diamonds);
}

var a = ['  mine bobovDol - gold-    10', 'mine medenRudnik - silver: 22', 'mine chernoMore - shrimps : 24'];

solve(a);