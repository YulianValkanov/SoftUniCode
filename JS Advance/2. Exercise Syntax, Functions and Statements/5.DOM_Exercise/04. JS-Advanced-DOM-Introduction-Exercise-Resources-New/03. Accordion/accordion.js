function toggle() {

    let butonElement = document.getElementsByClassName('button');
    let textElement = document.getElementById('extra');

    let textButon = butonElement[0].textContent;


    if (textButon == 'More') {

        textButon = 'Less';

        textElement.style.display = 'block';

    } else {
        textButon = 'More';

        textElement.style.display='none'
    }

    butonElement[0].textContent = textButon;

    console.log(textElement.textContent);
}