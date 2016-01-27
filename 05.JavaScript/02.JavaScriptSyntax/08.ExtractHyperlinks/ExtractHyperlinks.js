function solve (arr) {
    var html = arr.join('');
    var regex = /<a\s+[^>]*href\s*=\s*('([^']*)'|"([^"]*)"|([^\s>]+))[^>]*>/g;
    var myArray;

    while ((myArray = regex.exec(html)) != null) {
        if (myArray[3]) {
            console.log(myArray[3]);
        }
        if (myArray[2]) {
            console.log(myArray[2]);
        }
    }
}