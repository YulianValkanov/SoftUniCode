function sumTable() {

let tableElements=document.getElementsByTagName('td');

let arrayTable=Array.from(tableElements);
let sum=0;

for (let index = 1; index < arrayTable.length-2; index+=2) {
    
  sum+=Number(arrayTable[index].textContent);  
}

let elementSum=document.getElementById('sum');
elementSum.textContent=sum;


}