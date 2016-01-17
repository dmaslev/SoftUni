function solve(input) {
    var numbersOfJumpsAllow = parseInt(input[0]);
    var lenthOfTrack = parseInt(input[1]);
    var fleas = [];


    for (var i = 2; i < input.length; i++) {
        var temp = input[i].split(', ');
        var currentName = temp[0];
        var currentDist = parseInt(temp[1]);
        fleas.push(new Flea(currentName, currentDist, 0));
    }

    var winner = fleas[0].name;
    var maxPosition = 0;

    for (var i = 0; i < numbersOfJumpsAllow; i++) {
        for (var j = 0; j < fleas.length; j++) {
            var currentFlea = fleas[j];
            currentFlea.currentPosition += currentFlea.distance;

            if (currentFlea.currentPosition >= lenthOfTrack - 1) {
                winner = currentFlea.name;
                printResult();
                return;
            } else {
                if (currentFlea.currentPosition >= maxPosition) {
                    winner = currentFlea.name;
                    maxPosition = currentFlea.currentPosition;
                }
            }
        }
    }

    printResult();

    function printResult() {
        var line = new String();
        var dots = [];
        for (var i = 0; i < lenthOfTrack; i++) {
            line += '#';
            dots[i] = '.';
        }

        console.log(line);
        console.log(line);

        for (var i in fleas) {
            if (fleas[i].currentPosition >= lenthOfTrack) {
                fleas[i].currentPosition = lenthOfTrack-1;
            }

            dots[fleas[i].currentPosition] = fleas[i].name[0].toUpperCase();
            console.log(dots.join(''));
            dots[fleas[i].currentPosition] = '.';
        }

        console.log(line);
        console.log(line);
        console.log('Winner: ' + winner);
    }

    function Flea(name, distance, currentPosition) {
        return {
            name: name,
            distance: distance,
            currentPosition: currentPosition
        }
    }
}