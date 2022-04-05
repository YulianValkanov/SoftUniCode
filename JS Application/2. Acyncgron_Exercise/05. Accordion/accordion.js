function solution() {

    let mainElement = document.getElementById('main');


    let urlTitle = 'http://localhost:3030/jsonstore/advanced/articles/list';


    fetch(urlTitle)
        .then(res => res.json())
        .then(data => {

            data.forEach(el => {
                let createAcordeonElement = document.createElement('div');
                createAcordeonElement.className = 'accordion';


                let createDivHeadElement = document.createElement('div');
                createDivHeadElement.className = 'head';
                let createSpan = document.createElement('span');
                createSpan.textContent = el.title;
                let createButton = document.createElement('Button');
                createButton.className = 'button'
                createButton.textContent = 'More';
                createButton.id = el._id;

               
                createDivHeadElement.appendChild(createSpan);
                createDivHeadElement.appendChild(createButton);


                let createDivExtraElement = document.createElement('div');
                createDivExtraElement.className = 'extra';
                let createP = document.createElement('p');
                createP.textContent = 'Scalable Vector Graphics .....';

                createDivExtraElement.appendChild(createP);

                createAcordeonElement.appendChild(createDivHeadElement);
                createAcordeonElement.appendChild(createDivExtraElement);

                mainElement.appendChild(createAcordeonElement);


                 ////BUTON
            

                 createButton.addEventListener('click', (e) => {
             
                                                
                     if (e.currentTarget.textContent == 'More') {
                        createDivExtraElement.style.display = "block";
                        e.currentTarget.textContent = 'Less';
             
                         let urlOther = `http://localhost:3030/jsonstore/advanced/articles/details/${createButton.id}`
             
                         let request = fetch(urlOther)
                             .then(res => res.json())
                             .then(data => {
                                createP.textContent = data.content
                             });
             
                        
                     } else {
             
                        createDivExtraElement.style.display = "none";
                        e.currentTarget.textContent = 'More';
                     
             
                     }
             
             
             
             
             
                 })
 
                 //////END

            });

        })
        .catch(err => console.log(err));



   
}

solution();