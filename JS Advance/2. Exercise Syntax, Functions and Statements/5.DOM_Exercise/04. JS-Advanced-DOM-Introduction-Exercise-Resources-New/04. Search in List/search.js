function search() {


   let inputElement = document.getElementById('searchText');
   let inputText = inputElement.value;

   let resultElement = document.getElementById('result');

   let elements = document.getElementsByTagName('li');

   let matches = 0;

   for (const el of elements) {
      if (inputText.length === 0) {
         continue;
      }

      if (el.textContent.includes(inputText)) {

         matches++;

         el.style.textDecoration = 'underline';
         el.style.fontWeight='bold';
      }


   }

   resultElement.textContent = `${matches} matches found`;

}



//font-weight: bold;
//text-decoration: underline;