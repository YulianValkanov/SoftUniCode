
import { html } from "../../node_modules/lit-html/lit-html.js";

import * as albumservice from '../services/currentService.js'

export const carTemplate = (car, withDetails=true) => html`
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


const catalogTemplate = ( cars, user) => html`


<!-- All Listings Page -->
<section id="car-listings">
    <h1>Car Listings</h1>
    <div class="listings">

        <!-- Display all records -->

            ${cars.map(x=>carTemplate(x))}
        

        ${cars.length==0
        ? 
        html `
        <!-- Display if there are no records -->
        <p class="no-cars">No cars in database.</p>
        `
        : ''
        }

    </div>
</section>
`;

export const catalogView = (ctx) => {

    albumservice.getAll()
        .then(cars => {
            ctx.render(catalogTemplate(cars, ctx.user));
        });

}

