import { html } from "../../node_modules/lit-html/lit-html.js";

import * as albumservice from '../services/albumService.js'

export const deleteView = async (ctx) => {

    try {
        const album = await albumservice.getOne(ctx.params.albumId)

        let confirmed = confirm(`Do you want to datele the album: ${album.name}?`)

        if (confirmed) {
            await albumservice.remove(ctx.params.albumId); 
            ctx.page.redirect('/catalog');
        }
       
       

    } catch (err) {

        alert(err);

    }


}