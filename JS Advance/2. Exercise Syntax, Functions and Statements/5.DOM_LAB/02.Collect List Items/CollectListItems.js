function extractText() {
   
    let ulElement=document.getElementById('items');

    console.log(ulElement.textContent);

    let ulElementsText=ulElement.textContent;

    let textAriaElement=document.getElementById('result');

   

    textAriaElement.textContent=ulElementsText;
}