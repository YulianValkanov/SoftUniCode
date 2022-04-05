function attachEvents() {

 const url = 'http://localhost:3030/jsonstore/phonebook'

    let phoneBookElements = document.getElementById('phonebook');
    let buttonLoad = document.getElementById('btnLoad');
 
    let personElement = document.getElementById('person');
    let phoneElement = document.getElementById('phone');

    let buttonCreate = document.getElementById('btnCreate');

    buttonLoad.addEventListener('click', loaded)

    buttonCreate.addEventListener('click',create)
      

    async function loaded () {

        while( phoneBookElements.hasChildNodes() ){
            phoneBookElements.removeChild(phoneBookElements.lastChild);
        }

        let getPhonebook = await fetch(url);
    
        let data = await getPhonebook.json();
    
        for (const el of Object.values(data)) {
    
            let createButtonDelete=document.createElement('button');
            createButtonDelete.textContent='Delete';
            createButtonDelete.addEventListener('click',()=>{

            
                fetch(`${url}/${el._id}`,{
                    method: 'delete'      
                });

                buttonLoad.click();
 
            })
    
            let createLiElement = document.createElement('li'); 
            createLiElement.textContent = `${el.person}: ${el.phone}`;
            createLiElement.setAttribute('id',el._id);
            createLiElement.appendChild(createButtonDelete);
    
            phoneBookElements.appendChild(createLiElement);
            
        }
    };

    async function create(){
      
        if (personElement.value!=''&&phoneElement.value!='') {
            let obj={
                person: personElement.value,
                phone: phoneElement.value
            }
                 await fetch(url,{ 
                method: 'post',
                headers: {'Content-Type': 'application/json'},
                body: JSON.stringify(obj)
    
            });

            personElement.value='';
            phoneElement.value='';
            buttonLoad.click();

        }

       

    }

  

    
};


attachEvents();

