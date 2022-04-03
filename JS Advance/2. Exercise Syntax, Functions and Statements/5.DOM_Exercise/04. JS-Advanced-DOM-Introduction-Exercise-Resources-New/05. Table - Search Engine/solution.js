function solve() {

   document.querySelector('#searchBtn').addEventListener('click', onClick);

   let inputTextElement = document.getElementById('searchField');

   let rowEllements = document.querySelectorAll('tbody tr');

   function onClick() {

   

      for (const curentRow of rowEllements) {

         curentRow.classList.remove('select');

         if (curentRow.textContent.includes(inputTextElement.value) && inputTextElement.value != '') {
              
            curentRow.className='select';
         }

      }

      inputTextElement.value='';

   }

}
