function calc() {
    
    let firstNumElement=document.getElementById('num1');
    let secondElement=document.getElementById('num2');
    let sumElement=document.getElementById('sum');
  

    let firstNum=Number(firstNumElement.value);
    let secondNum=Number(secondElement.value);
    let result=firstNum+secondNum;

    sumElement.value=result;
  
}
