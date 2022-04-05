
import { homePage } from "./home.js";
import { showView } from "./util.js";

const url = 'http://localhost:3030/data/movies';


const section=document.getElementById("add-movie");
const form=section.querySelector('form');
form.addEventListener('submit',onSubmit)



export function createPage(){
    showView(section);
}


async function onSubmit(event) {
    event.preventDefault();

    const formData = new FormData(form);

    const title=formData.get('title')
    const desctiption=formData.get('description')
    const img=formData.get('imageUrl')
    
    await createMovie(title,desctiption,img);
    form.reset();
    homePage();

}


async function createMovie(title,desctiption,img){

    const user=JSON.parse(localStorage.getItem('user'));

    await fetch(url, {
        method: "POST",
        headers: {
            'Content-Type': 'application/json',
            'X-Authorization' : user.accessToken
        },
        body: JSON.stringify({ title,desctiption,img })
    });

}

window.createMovie=createMovie;