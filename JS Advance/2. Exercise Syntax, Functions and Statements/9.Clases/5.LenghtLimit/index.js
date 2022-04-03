class Stringer {

    constructor(str, length) {
        this.inerString = str;
        this.innerLenght = length;

    }

    increase(length) {
        this.innerLenght += length;

    }

    decrease(length) {
        this.innerLenght -= length;
        if (this.innerLenght < 0) {
            this.innerLenght = 0;
        }
    }

    toString() {


        if (this.innerLenght === 0) {
            return '...';
        }
        else if (this.inerString.length > this.innerLenght) {
            return this.inerString.substring(0, this.innerLenght) + '...';
        } else {
            return this.inerString;
        }

    }

}








let test = new Stringer("Test", 5);
console.log(test.toString()); // Test

test.decrease(3);
console.log(test.toString()); // Te...

test.decrease(5);
console.log(test.toString()); // ...

test.increase(4);
console.log(test.toString()); // Test
