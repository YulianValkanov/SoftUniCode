function attachEvents() {

    let textAreaElement=document.getElementById('messages');
    let nameElement=document.querySelector("input[name='author']");
    let messageElement=document.querySelector("input[name='content']");
    let buttonSubmit=document.getElementById('submit');
    let buttonRefresh=document.getElementById('refresh');

    let url='http://localhost:3030/jsonstore/messenger';

    buttonSubmit.addEventListener('click',()=>{

        if (nameElement.value==''||messageElement.value=='') {
           
            alert('Emply feelds!!!');
         
        }else{
            let message={
                author: nameElement.value,
                content: messageElement.value,      
            };
    
            fetch(url,{
                method: 'post',
                headers: {'Content-Type': 'application/json'},
                body: JSON.stringify(message)
            })

            nameElement.value='';
            messageElement.value='';
        }


    })

    buttonRefresh.addEventListener('click',()=>{
      
        fetch(url)
        .then(x=>x.json())
        .then(data=>{
            let result='';

            for (const people of Object.values(data)) {
            
              
                result+=`${people.author}: ${people.content}\n`;
            }
         
            


            textAreaElement.textContent= result;

        })

    })



}

attachEvents();