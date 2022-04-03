
function demo(input) {

    let inputNumber = input.toString();
    let isSame = true;
    let sumOfdigits = 0;
    let digitToCompare = +inputNumber[0];
   


    for (let i = 0; i < inputNumber.length  ; i++) {

       let currentDigit = +inputNumber[i];

        sumOfdigits += currentDigit;

        if (currentDigit !== digitToCompare) {
            isSame = false;
        }


    }
    console.log(isSame);
    console.log(sumOfdigits);
}


demo(22222);