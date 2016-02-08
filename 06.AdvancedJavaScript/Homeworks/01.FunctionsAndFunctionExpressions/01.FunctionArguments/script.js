function printArgsInfo() {
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


//printArgsInfo(2, 3, 2.5, -110.5564, false);

//printArgsInfo(null, undefined, "", 0, [], {}) ;

//printArgsInfo([1, 2], ["string", "array"], ["single value"]);

//printArgsInfo("some string", [1, 2], ["string", "array"], ["mixed", 2, false, "array"], {name: "Peter", age: 20});

printArgsInfo([[1, [2, [3, [4, 5]]]], ["string", "array"]]);