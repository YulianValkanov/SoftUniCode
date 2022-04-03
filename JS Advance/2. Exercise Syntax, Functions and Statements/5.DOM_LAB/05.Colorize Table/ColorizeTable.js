function colorize() {
   
    //let tableElements=document.querySelectorAll('tr:nth-of-type(2n) td');

   // tableElements.forEach(x=>{
   //     x.style.backgroundColor='teal';
   // });

   let elements=document.getElementsByTagName('tr');

   let arrSS=Array.from(elements);

   for (let index = 0; index < arrSS.length; index++) {
   
    if (index%2!=0) {
        arrSS[index].style.backgroundColor='teal';
    } 
    

   }
}