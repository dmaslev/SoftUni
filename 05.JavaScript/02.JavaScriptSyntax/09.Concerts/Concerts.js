function solve (input) {
    var result = {};
    for (var i in input) {
        var line = input[i].split('|');
        var band = line[0].trim();
        var town = line[1].trim();
        var venue = line[3].trim();

        if (!result[town]) {
            result[town] = {};
        }

        if (!result[town][venue]) {
            result[town][venue] = [];
        }

        if (result[town][venue].indexOf(band) === -1) {
            result[town][venue].push(band);
        }
    }

    result = sortObjectProperties(result);
    for (var town in result) {
        result[town] = sortObjectProperties(result[town]);
        for (var venue in result[town]) {
            result[town][venue].sort();
        }
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