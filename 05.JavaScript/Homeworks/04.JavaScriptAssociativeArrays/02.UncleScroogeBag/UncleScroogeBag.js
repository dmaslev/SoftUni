function solve(arr) {
    var coins = 0;
    for (var i = 0; i < arr.length; i++) {
        var values = arr[i].split(' ');
        var type = values[0];
        var value = values[1];
        if(type.toLowerCase() === 'coin') {
            if(isInteger(value)) {
                coins += parseInt(value);
            }
        }
    }

    function  isInteger(value) {
        if(value % 1 === 0 && value > 0) {
            return true;
        }

        return false;
    }

    var goldCoins = Math.floor(coins / 100);
    var silverCoins = Math.floor((coins % 100 ) / 10);
    var bronzeCoins = coins % 10;
    console.log('gold : ' + goldCoins);
    console.log('silver : ' + silverCoins);
    console.log('bronze : ' + bronzeCoins);
}