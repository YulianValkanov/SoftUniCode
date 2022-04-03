function demo(input) {
    let matrix = input;
    let newMatrix = [];

    let firstDiagonal = 0;
    let secondDiagonal = 0;

    for (let row = 0; row < matrix.length; row++) {

        let currentRowArr = (matrix[row]).split(" ");

        for (let col = 0; col < matrix.length; col++) {
            newMatrix[row] = currentRowArr
        }

    };

    let newMatrixLength = (newMatrix[0]).length;

    for (let i = 0; i < newMatrixLength; i++) {
        firstDiagonal += Number(newMatrix[i][i]);
        secondDiagonal += Number(newMatrix[i][newMatrixLength - 1 - i]);
    }



    if (firstDiagonal == secondDiagonal) {
        for (let row = 0; row < newMatrixLength; row++) {
            for (let col = 0; col < newMatrixLength; col++) {

                if (row == col) {
                    continue;
                }

                if (row+col==newMatrixLength-1) {
                    continue;
                }

                newMatrix[row][col]=firstDiagonal;

            }

        }
    }

    for (const element of newMatrix) {
        console.log(element.join(" "));
    }


};


demo(
    ['1 1 1',
    '1 1 1',
    '1 1 0']
    
    
);