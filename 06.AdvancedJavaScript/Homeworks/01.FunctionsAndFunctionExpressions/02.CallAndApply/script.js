function printArgsInfo() {
    if (arguments.length === 0) {
        console.log("No arguments.");
        return;
    }

    for (var obj in arguments) {
        var currentElement = arguments[obj];
        var type;
        if (Array.isArray(currentElement)) {
            type = "array";
        } else {
            type = typeof (currentElement);
        }

        console.log(currentElement + '(' + type + ')' );
    }
}

printArgsInfo.call(null);
printArgsInfo.call(null, 2, NaN, undefined);

printArgsInfo.apply(null);
printArgsInfo.apply(null, [[1, 2]]);