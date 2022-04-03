function editElement(refference, match, replacer) {

    while (refference.textContent.includes(match)) {
        refference.textContent= refference.textContent.replace(match,replacer)
    }
 
}



  //whie(element.textContent.includes(match)) {
   // element.textContent = element.textContent.replace(match, replacer);


// regex solution
// let pattern = new RegExp(match, 'g')
// element.textContent = element.textContent.replace(pattern, replacer);
