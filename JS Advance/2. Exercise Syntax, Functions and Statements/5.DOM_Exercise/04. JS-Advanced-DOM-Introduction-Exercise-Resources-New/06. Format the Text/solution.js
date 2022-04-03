function solve() {

  let textElement = document.getElementById('input');

  let resultElement = document.getElementById('output');

  let textArr=textElement.value.split('.').filter(s=>s!=='');

  while (textArr.length>0) {
    
let text=textArr.splice(0,3).join('. ')+'.';
let p =document.createElement('p');
p.textContent=text;
resultElement.appendChild(p);

  }


}