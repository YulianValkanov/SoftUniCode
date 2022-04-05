import { html } from "../../node_modules/lit-html/lit-html.js";

import * as albumservice from '../services/currentService.js'

const detailsTemplate =(car, user)=>html `

<!-- Listing Details Page -->
<section id="listing-details">
    <h1>Details</h1>
    <div class="details-info">
        <img src="${car.imageUrl}">
        <hr>
        <ul class="listing-props">
            <li><span>Brand:</span>${car.brand}</li>
            <li><span>Model:</span>${car.model}</li>
            <li><span>Year:</span>${car.year}</li>
            <li><span>Price:</span>${car.price}$</li>
        </ul>

        <p class="description-para">${car.description}</p>

        ${
             !user ||  car._ownerId!=user._id
            ? 
             `
           
            `
            :html`
             <div class="listings-buttons">
            <a href="/cars/${car._id}/edit" class="button-list">Edit</a>
            <a href="/cars/${car._id}/delete" class="button-list">Delete</a>
        </div>`
        }
       
    </div>
</section>
`

export const detailsView=(ctx)=>{

albumservice.getOne(ctx.params.carId)
.then(car=>{
    ctx.render(detailsTemplate(car, ctx.user))
})
}