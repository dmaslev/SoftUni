"use strict";

Array.prototype.removeItem = function(item) {
    while (this.indexOf(item) !== -1) {
        this.splice(this.indexOf(item), 1);
    }
};

var arr = [1, 2, 1, 4, 1, 3, 4, 1, 111, 3, 2, 1, '1'];
arr.removeItem(1);
console.log(arr);

var arr = ['hi', 'bye', 'hello'];
arr.removeItem('bye');
console.log( arr);