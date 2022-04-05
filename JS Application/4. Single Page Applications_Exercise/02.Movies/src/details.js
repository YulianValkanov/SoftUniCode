import { showView, spinner } from "./util.js";

const section = document.getElementById("movie-example");

const url = 'http://localhost:3030/data/movies/';

export function detailsPage(id) {
    showView(section);
    displayMovie(id)
}

async function displayMovie(id) {

    //section.replaceChildren(spinner())

    const movie = await getMovie(id);

    section.replaceChildren(movie)
}



async function CreateMovieCard(movie) {
    const element = document.createElement('div');
    element.className = 'container';
    element.innerHTML = `
<div class="container">
<div class="row bg-light text-dark">
    <h1>Movie title:${movie.title}</h1>

    <div class="col-md-8">
        <img class="img-thumbnail" src="${movie.img}"
             alt="Movie">
    </div>
    <div class="col-md-4 text-center">
        <h3 class="my-3 ">Movie Description</h3>
        <p> ${movie.description}</p>
        <a class="btn btn-danger" href="#">Delete</a>
        <a class="btn btn-warning" href="#">Edit</a>
        <a class="btn btn-primary" href="#">Like</a>
        <span class="enrolled-span">Liked 1</span>
    </div>
</div>
</div> 
`
}

async function getMovie(id) {
    const res = await fetch(`http://localhost:3030/data/movies/${id}`);
    const movie = await res.json();

    return movie;
}