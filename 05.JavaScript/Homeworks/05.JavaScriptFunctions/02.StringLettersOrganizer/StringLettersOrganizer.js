function sortLetters(word, order) {
    var wordAsArr = word.split('').sort(function (x, y) {
        if (order) {
            return x.toLowerCase() > y.toLowerCase();
        } else {
            return x.toLowerCase() < y.toLowerCase();
        }
    });

    console.log(wordAsArr.join(''));
}

sortLetters('HelloWorld', true);
sortLetters('HelloWorld', false);