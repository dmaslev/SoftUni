function solve(input) {
    var result = [];
    for (var i = 0; i < input.length; i++) {
        var line = input[i];
        var arr = line.split(/[:\/-]/g);
        var firstTeam = arr[0].trim();
        var secondTeam = arr[1].trim();
        var firstScore = parseInt(arr[2].trim());
        var secondScore = parseInt(arr[3].trim());
        if (result[firstTeam] == undefined) {
            result[firstTeam] = {goalsScored: firstScore, goalsConceded: secondScore, matchesPlayedWith: [secondTeam]};
        } else {
            result[firstTeam].goalsScored += firstScore;
            result[firstTeam].goalsConceded += secondScore;
            if (result[firstTeam].matchesPlayedWith.indexOf(secondTeam) == -1) {
                result[firstTeam].matchesPlayedWith.push(secondTeam);
            }
        }

        if (result[secondTeam] == undefined) {
            result[secondTeam] = {goalsScored: secondScore, goalsConceded: firstScore, matchesPlayedWith: [firstTeam]}
        } else {
            result[secondTeam].goalsScored += secondScore;
            result[secondTeam].goalsConceded += firstScore;
            if (result[secondTeam].matchesPlayedWith.indexOf(firstTeam) == -1) {
                result[secondTeam].matchesPlayedWith.push(firstTeam);
            }
        }
    }

    result = sortObjectProperties(result);


    for (var i in result) {
        result[i].matchesPlayedWith.sort();
    }

    console.log(JSON.stringify(result));

    function sortObjectProperties(obj) {
        var keysSorted = Object.keys(obj).sort();
        var sortedObj = {};
        for (var i = 0; i < keysSorted.length; i++) {
            var key = keysSorted[i];
            sortedObj[key] = obj[key];
        }
        return sortedObj;
    }
}