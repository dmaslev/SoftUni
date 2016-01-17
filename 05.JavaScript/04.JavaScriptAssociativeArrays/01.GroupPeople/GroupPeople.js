function Person(firstName, lastName, age) {
    return {
        firstName: firstName,
        lastName: lastName,
        age: age,
        toString: function () {
            return this.firstName + ' ' + this.lastName + '(age ' + this.age + ')';
        }
    }
}

function groupBy(arr, criteria) {
    var result = [];
    if (criteria === 'firstName') {
        for (var p in arr) {
            if (result[arr[p].firstName] == undefined) {
                result[arr[p].firstName] = [];
            }

            result[arr[p].firstName].push(arr[p]);
        }
    } else if (criteria === 'lastName') {
        for (var p in arr) {
            if (result[arr[p].lastName] == undefined) {
                result[arr[p].lastName] = [];
            }

            result[arr[p].lastName].push(arr[p]);
        }
    } else if (criteria === 'age') {
        for (var p in arr) {
            if (result[arr[p].age] == undefined) {
                result[arr[p].age] = [];
            }

            result[arr[p].age].push(arr[p]);
        }
    }

    return result;
}

var people = [
    new Person("Scott", "Guthrie", 38),
    new Person("Scott", "Johns", 36),
    new Person("Scott", "Hanselman", 39),
    new Person("Jesse", "Liberty", 57),
    new Person("Jon", "Skeet", 38)
];

var grouped = groupBy(people, 'firstName');
for (var p in grouped) {
    console.log('Group ' + p + ' : [' + grouped[p].join(', ') + ']');
}

console.log();
var grouped = groupBy(people, 'lastName');
for (var p in grouped) {
    console.log('Group ' + p + ' : [' + grouped[p].join(', ') + ']');
}
console.log();
var grouped = groupBy(people, 'age');
for (var p in grouped) {
    console.log('Group ' + p + ' : [' + grouped[p].join(', ') + ']');
}