import { html } from "../../node_modules/lit-html/lit-html.js";

import * as albumservice from '../services/currentService.js';

import { albumIsInvalid } from '../utils/validators.js'

const editTemplate = (car, submitHandler) => html`
<!-- Edit Listing Page -->
<section id="edit-listing">
    <div class="container">

        <form @submit=${submitHandler} id="edit-form">
            <h1>Edit Car Listing</h1>
            <p>Please fill in this form to edit an listing.</p>
            <hr>

            <p>Car Brand</p>
            <input type="text" placeholder="Enter Car Brand" name="brand" value="${car.brand}">

            <p>Car Model</p>
            <input type="text" placeholder="Enter Car Model" name="model" value="${car.model}">

            <p>Description</p>
            <input type="text" placeholder="Enter Description" name="description" value="${car.description}">

            <p>Car Year</p>
            <input type="number" placeholder="Enter Car Year" name="year" value="${car.year}">

            <p>Car Image</p>
            <input type="text" placeholder="Enter Car Image" name="imageUrl" value="${car.imageUrl}">

            <p>Car Price</p>
            <input type="number" placeholder="Enter Car Price" name="price" value="${car.price}">

            <hr>
            <input type="submit" class="registerbtn" value="Edit Listing">
        </form>
    </div>
</section>
`;

export const editView = (ctx) => {

const carId=ctx.params.carId;

    const submitHandler = (e) => {

        e.preventDefault();

        let cardata = Object.fromEntries(new FormData(e.currentTarget));

        if (albumIsInvalid(cardata)) {
            alert('All fields should be filled')
            return;
        };

        albumservice.edit(carId, cardata).then(ctx.page.redirect(`/cars/${carId}`))
       
    }


    albumservice.getOne(carId)
        .then(car => {
            ctx.render(editTemplate(car, submitHandler))
        })
}