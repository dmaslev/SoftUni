function solve(input) {
    var result = [];

    for (var i = 0; i < input.length; i++) {
        var line = input[i];
        line = line.replace('vs.', ' vs. ');
        line = line.replace(':', ' : ');
        line = line.replace(/\s+/g, ' ');

        var params = line.split(' ');
        var p1name = params[0] + ' ' + params[1];
        var p2name = params[3] + ' ' + params[4];

        var p1 = null, p2 = null;
        for (var index in result) {
            var current = result[index];
            if (current.name == p1name) {
                p1 = current;
            } else if (current.name == p2name) {
                p2 = current;
            }
        }

        if (p1 == null) {
            p1 = {name: p1name, matchesWon: 0, matchesLost: 0, setsWon: 0, setsLost: 0, gamesWon: 0, gamesLost: 0};
            result.push(p1);
        }
        if (p2 == null) {
            p2 = {name: p2name, matchesWon: 0, matchesLost: 0, setsWon: 0, setsLost: 0, gamesWon: 0, gamesLost: 0};
            result.push(p2);
        }
        var a = 0;
        var b = 0;

        for (var j = 6; j < params.length; j++) {
            var obj = params[j];
            var scores = obj.split('-');
            var s1 = Number(scores[0]);
            var s2 = Number(scores[1]);
            p1.gamesWon += s1;
            p1.gamesLost += s2;
            p2.gamesWon += s2;
            p2.gamesLost += s1;

            if (s1 > s2) {
                a++;
            } else {
                b++;
            }
        }

        if (a > b) {
            p1.matchesWon++;
            p2.matchesLost++;
            p1.setsWon += a;
            p1.setsLost += b;
            p2.setsWon+=b;
            p2.setsLost+=a;
        } else {
            p2.matchesWon++;
            p1.matchesLost++;
            p2.setsWon += b;
            p2.setsLost += a;
            p1.setsWon+=a;
            p1.setsLost+=b;
        }
    }

    result.sort(function (a, b) {
        if (a.matchesWon == b.matchesWon) {
            if (a.setsWon == b.setsWon) {
                var aRatio = 1;
                if(a.matchesLost !=0) {
                     aRatio = a.matchesWon / a.matchesLost;
                }
                var bRatio = 1;
                if (b.matchesLost !=0) {
                    bRatio = b.matchesWon / b.matchesLost;

                }

                if (aRatio == bRatio) {
                    if (a.gamesWon == b.gamesWon) {
                        return a.name.localeCompare(b.name);
                    }

                    return b.gamesWon - a.gamesWon;
                }

                return bRatio - aRatio;
            }

            return b.setsWon - a.setsWon;
        }

        return b.matchesWon - a.matchesWon;
    });

    console.log(JSON.stringify(result));
}

arr = ['Novak Djokovic vs. Roger Federer : 6-3 6-3',
    'Roger    Federer    vs.        Novak Djokovic    :         6-2 6-3',
    'Rafael Nadal vs. Andy Murray : 4-6 6-2 5-7',
    'Andy Murray vs. David     Ferrer : 6-4 7-6',
    'Tomas   Bedrych vs. Kei Nishikori : 4-6 6-4 6-3 4-6 5-7',
    'Grigor Dimitrov vs. Milos Raonic : 6-3 4-6 7-6 6-2',
    'Pete Sampras vs. Andre Agassi : 2-1',
    'Boris Beckervs.Andre        Agassi:2-1'];

solve(arr);