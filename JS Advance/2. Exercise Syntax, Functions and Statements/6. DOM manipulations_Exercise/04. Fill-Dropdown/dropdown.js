function addItem() {
    let newtext=document.getElementById('newItemText').value;

    let newValue=document.getElementById('newItemValue').value;

    let selectmenu=document.getElementById('menu');

    let option=document.createElement('option');
    option.text=newtext;
    option.value=newValue;

    selectmenu.appendChild(option);

    document.getElementById('newItemText').value='';

   document.getElementById('newItemValue').value='';

   
}