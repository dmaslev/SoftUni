function testContext() {
    console.log(this);
}

function otherFunction() {
    function inner() {
        testContext();
    }

    inner();
}

var obj = {};

testContext();

otherFunction();

testContext.call(obj);
