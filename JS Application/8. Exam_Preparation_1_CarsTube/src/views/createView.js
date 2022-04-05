import { html } from "../../node_modules/lit-html/lit-html.js";

import * as albumservice from '../services/currentService.js';

import {albumIsInvalid} from '../utils/validators.js'

const createTemplate = (submitHandler) => html`
<!-- Create Listing Page -->
<section id="create-listing">
    <div class="container">
        <form @submit=${submitHandler} id="create-form">
            <h1>Create Car Listing</h1>
            <p>Please fill in this form to create an listing.</p>
            <hr>

            <p>Car Brand</p>
            <input type="text" placeholder="Enter Car Brand" name="brand">

            <p>Car Model</p>
            <input type="text" placeholder="Enter Car Model" name="model">

            <p>Description</p>
            <input type="text" placeholder="Enter Description" name="description">

            <p>Car Year</p>
            <input type="number" placeholder="Enter Car Year" name="year">

            <p>Car Image</p>
            <input type="text" placeholder="Enter Car Image" name="imageUrl">

            <p>Car Price</p>
            <input type="number" placeholder="Enter Car Price" name="price">

            <hr>
            <input type="submit" class="registerbtn" value="Create Listing">
        </form>
    </div>
</section>
`;




export const createView = (ctx) => {

    const submitHandler = (e) => {
        e.preventDefault();
        console.log('asdasd');
        let cardata = Object.fromEntries(new FormData(e.currentTarget));
        console.log(cardata);
        console.log('asdasd');

        if (albumIsInvalid(cardata)) {
            alert('All fields should be filled')
            return;
        }

        if (cardata.year<=0 || cardata.price<=0) {
            alert('Price or year must be positive')
            return;
        }

        albumservice.create(cardata)
            .then(() => {
                ctx.page.redirect('/catalog');
            })
            .catch(err => {
                alert(err)
            });
    }
    ctx.render(createTemplate(submitHandler))

}