import { html } from "../../node_modules/lit-html/lit-html.js";

import * as albumservice from '../services/currentService.js'

export const deleteView = async (ctx) => {

    try {
        const car = await albumservice.getOne(ctx.params.carId)

        let confirmed = confirm(`Do you want to datele the album: ${car.model}?`)

        if (confirmed) {
            await albumservice.remove(ctx.params.carId); 
            ctx.page.redirect('/catalog');
        }
       
       

    } catch (err) {

        alert(err);

    }


}