function demo(number, input1, input2, input3, input4, input5) {
   
    let currentNumber = Number(number);
    let comands = [input1, input2, input3, input4, input5]

    let chop = function () {
        return currentNumber / 2;
    }
    let dice = function () {
        return Math.sqrt(currentNumber);
    }
    let spice = function () {
        return currentNumber + 1;
    }
    let bake = function () {
        return currentNumber * 3;
    }
    let fillet = function () {
        return currentNumber * 0.8;
    }

    for (i = 0; i < comands.length; i++) {
        let currentComand = comands[i];

        switch (currentComand) {
            case 'chop':
                currentNumber=chop(currentNumber);
                break;
            case 'dice':
                currentNumber=dice(currentNumber);
                break;
            case 'spice':
                currentNumber=spice(currentNumber);
                break;
            case 'bake':
                currentNumber=bake(currentNumber);
                break;
            case 'fillet':
                currentNumber=fillet(currentNumber);
                break;
        }
        console.log(currentNumber);
    }


  
}

demo('9', 'dice', 'spice', 'chop', 'bake', 'fillet');