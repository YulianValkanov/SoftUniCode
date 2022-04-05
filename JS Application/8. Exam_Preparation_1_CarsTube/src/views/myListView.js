import { html } from "../../node_modules/lit-html/lit-html.js";

import * as albumservice from '../services/currentService.js'

const carTemplate=(car)=>html`
<div class="listing">
<div class="preview">
    <img src="${car.imageUrl}">
</div>
<h2>${car.brand} ${car.model}</h2>
<div class="info">
    <div class="data-info">
        <h3>Year: ${car.year}</h3>
        <h3>Price: ${car.price} $</h3>
    </div>
    <div class="data-buttons">
        <a href="/cars/${car._id}" class="button-carDetails">Details</a>
    </div>
</div>
</div>
`


const myListTemplate=(cars,user)=> html`

<!-- My Listings Page -->
<section id="my-listings">
    <h1>My car listings</h1>
    <div class="listings">

        <!-- Display all records -->
       
        ${ cars.map(car=>  car._ownerId==user._id ? carTemplate(car) : '') }

        ${ cars.some(x=>x._ownerId==user._id) 
        ? ''
        : 
        html `
        <!-- Display if there are no records -->
        <p class="no-cars"> You haven't listed any cars yet.</p>
        
        `
        }
     
        
       
    </div>
</section>
`

export const myListView = (ctx) => {
    

   
    albumservice.getAll()
        .then(cars => {
            ctx.render(myListTemplate(cars, ctx.user));
        });

}