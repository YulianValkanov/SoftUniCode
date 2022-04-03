window.addEventListener('load', solve);

function solve() {

    let totalPriceElement=document.querySelector('.total-price');
    let totalSum=0;
    
    let furnitureListElements = document.getElementById('furniture-list');

    let butonAddElement = document.getElementById('add');

    let modelElement = document.getElementById('model');
    let yearElement = document.getElementById('year');
    let descriptionElement = document.getElementById('description');
    let priceElement = document.getElementById('price');



    butonAddElement.addEventListener('click', (e) => {
        e.preventDefault();

        let modelElement = document.getElementById('model');
        let yearElement = document.getElementById('year');
        let descriptionElement = document.getElementById('description');
        let priceElement = document.getElementById('price');

    
       if (modelElement.value==null
        || modelElement.value==""
        || descriptionElement.value==null
        || descriptionElement.value=="") {
           return;
       }

       if (priceElement.value<=0
        ||yearElement.value<=0) {
           return;
       }
       
        ///Class Info
        let tableElement = document.createElement('tr');
        tableElement.className = "info";
       // tableElement.classList.add('info');

        //add furniture
        let currentFurnitureElelent = document.createElement('td');
        currentFurnitureElelent.textContent = modelElement.value;
        tableElement.appendChild(currentFurnitureElelent);

        //add price
        let currentPrice = document.createElement('td');
        currentPrice.textContent = Number(priceElement.value).toFixed(2);
        tableElement.appendChild(currentPrice);

        //buttons
        let cyrrentActionsElements = document.createElement('td');

        ///Create butron More info
        let createButonInfo = document.createElement("button");
        createButonInfo.className = "moreBtn";
        createButonInfo.textContent = "More Info"
        cyrrentActionsElements.appendChild(createButonInfo);

        createButonInfo.addEventListener('click',()=>{
            if( createButonInfo.textContent=="More Info"){
                createButonInfo.textContent="Less Info";
                hideElement.style.display = 'contents';
            }else{
                createButonInfo.textContent="More Info";
                hideElement.style.display = 'none';
            }
        })

        //Create button Buy
        let createButonBay = document.createElement("button");
        createButonBay.className = "buyBtn";
        createButonBay.textContent = "Buy it"
        cyrrentActionsElements.appendChild(createButonBay);

        createButonBay.addEventListener("click",(e)=>{

            totalSum += Number(e.currentTarget.parentElement.previousSibling.textContent);
            totalPriceElement.textContent=totalSum.toFixed(2);
    
            tableElement.remove();
            hideElement.remove();

            //e.currentTarget.parentElement.parentElement.nextSibling.remove();
           // e.currentTarget.parentElement.parentElement.remove();
           
            
        })


        tableElement.appendChild(cyrrentActionsElements);

        ///class hide
        let hideElement = document.createElement('tr');
        hideElement.className = "hide";
      

        //year
        let createYearElement = document.createElement('td');
        createYearElement.textContent = `Year: ${Number(yearElement.value)}`;
        hideElement.appendChild(createYearElement);

        //description
        let createDescriptionElement = document.createElement('td');
        createDescriptionElement.setAttribute('colspan', '3');
        createDescriptionElement.textContent = `Description: ${descriptionElement.value}`;
        hideElement.appendChild(createDescriptionElement);

        furnitureListElements.appendChild(tableElement);
        furnitureListElements.appendChild(hideElement);

        modelElement = document.getElementById('model').value='';
        yearElement = document.getElementById('year').value='';
        descriptionElement = document.getElementById('description').value='';
        priceElement = document.getElementById('price').value='';

 
    });


}
