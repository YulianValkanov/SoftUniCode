window.addEventListener('load', solve);

function solve() {
   
    let productElement = document.getElementById("type-product");
    let descriptionElement = document.getElementById('description');
    let clientNameElement = document.getElementById('client-name');
    let phoneElement = document.getElementById('client-phone');

    let submitButton = document.querySelector('button[type=submit]');

    let recivedOrdersElement=document.getElementById('received-orders');

    let completedOrderElement=document.getElementById('completed-orders');

    let clearElement=document.querySelector('button[class=clear-btn]');

   
    submitButton.addEventListener('click', (e) => {
        e.preventDefault();

        let procuct = productElement.value;
        let description = descriptionElement.value;
        let name = clientNameElement.value;
        let phone = phoneElement.value;

        if (description=="" ||
        name==""||
        phone=="") {
            return;
        };

        if (typeof(description)!='string'||
        typeof(name)!='string'||
        typeof(phone)!='string') {
            return;
        };

        productElement.value='';
        descriptionElement.value='';
        clientNameElement.value='';
        phoneElement.value='';

        let createDiv=document.createElement('div');
        createDiv.className='container';

        let createH2=document.createElement('h2');
        createH2.textContent=`Product type for repair: ${procuct}`;

        let createH3=document.createElement('h3');
        createH3.textContent=`Client information: ${name}, ${phone}`;

        let createH4=document.createElement('h4');
        createH4.textContent=`Description of the problem: ${description}`;

        let createButton1=document.createElement('button');
        createButton1.className='start-btn';
        createButton1.textContent='Start repair';

        let createButton2=document.createElement('button');
        createButton2.className='finish-btn';
        createButton2.textContent='Finish repair';
        createButton2.disabled=true;

        createDiv.appendChild(createH2);
        createDiv.appendChild(createH3);
        createDiv.appendChild(createH4);
        createDiv.appendChild(createButton1);
        createDiv.appendChild(createButton2);

        recivedOrdersElement.appendChild(createDiv);
    

        createButton1.addEventListener('click',(e)=>{
            e.target.disabled = true;
            createButton2.disabled=false;
        })

        createButton2.addEventListener('click',()=>{
            completedOrderElement.appendChild(createDiv);
            createDiv.removeChild(createButton1);
            createDiv.removeChild(createButton2);
        })





    });

 
    clearElement.addEventListener('click', ()=>{

        completedOrderElement.querySelectorAll('.container').forEach(el => el.remove());
        
    

     
           
    
    });


}