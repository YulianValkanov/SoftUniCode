function demo(input) {

    let array = input;

    let result = [];

    let bigestNum = Number(array[0]);

    result.push(bigestNum);

    for (i = 0; i < array.length; i++) {
  
        let secondNumber = Number(array[i + 1]);

        if (secondNumber>bigestNum) {
            result.push(secondNumber);
            bigestNum=secondNumber;
        }

    }

    return result;

}

demo([20, 
    3, 
    2, 
    15,
    6, 
    1]
    
);