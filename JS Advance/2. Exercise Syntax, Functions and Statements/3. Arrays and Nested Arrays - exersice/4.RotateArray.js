function demo(array,number){

let currArr=array;
let currNum=Number(number);

for (i=0;i<currNum;i++){
    let last=currArr.pop();
    currArr.unshift(last)

}

console.log(currArr.join(' '));
}



demo(['Banana', 
'Orange', 
'Coconut', 
'Apple'], 
15

);