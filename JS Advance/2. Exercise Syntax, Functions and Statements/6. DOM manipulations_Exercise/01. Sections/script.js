function create(words) {
  


   let wordsArr = words;

   let divElement = document.getElementById('content');




   wordsArr.forEach(x => {

      let createDivElement = document.createElement('div');
      let createPelement = document.createElement("p");
      createPelement.textContent = x;
      createPelement.style.display = 'none';

      createDivElement.addEventListener('click',function(x){
        //x.target.children[0].style.display = 'show';
      x.target.children[0].style.display='block';
        
      });
      

      createDivElement.appendChild(createPelement);

      divElement.appendChild(createDivElement);
   });

}