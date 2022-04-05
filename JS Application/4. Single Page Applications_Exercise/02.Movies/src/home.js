
import { showView, spinner } from "./util.js";

const section = document.getElementById("home-page");
const catalog=section.querySelector('#movie .card-deck.d-flex.justify-content-center');

catalog.addEventListener('click',(event)=>{
  

if (event.target.tagName=='BUTTON') {
    event.preventDefault();

    const id=event.target.dataset.id;
    console.log(id);

}
})

export function homePage() {
    showView(section);
    displayMovie();

};

const url = 'http://localhost:3030/data/movies';

async function displayMovie(){
    catalog.replaceChildren(spinner())
const movies=await getMovies();
 catalog.replaceChildren( ...movies.map(crateMoviePreview));
}

function crateMoviePreview(movie){

    const element=document.createElement('div');
    element.className='card mb-4';
    element.innerHTML=`
    <div class="card mb-4">
<img class="card-img-top" src="${movie.img}"
     alt="Card image cap" width="400">
<div class="card-body">
    <h4 class="card-title">${movie.title}</h4>
</div>
<div class="card-footer">
    <a  href="/details/${movie._id}">
        <button type="button" class="btn btn-info">Details</button>
    </a>
</div>
    `

    return element;
}


async function getMovies() {
    const res = await fetch(url);
    let data = await res.json();

    return data

}

window.getMovies=getMovies;
