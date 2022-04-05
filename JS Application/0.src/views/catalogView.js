
import { html } from "../../node_modules/lit-html/lit-html.js";

import * as albumservice from '../services/albumService.js'

export const albumTemplate = (album, withDetails=true) => html`
<div class="card-box">
        <img src="${album.imgUrl}">
        <div>
            <div class="text-center">
                <p class="name">Name: ${album.name}</p>
                <p class="artist">Artist: ${album.artist}</p>
                <p class="genre">Genre: ${album.genre}</p>
                <p class="price">Price: $${album.price}</p>
                <p class="date">Release Date: ${album.releaseDate}</p>
            </div>
            <div class="btn-group">
                ${ withDetails ? html` <a href="/albums/${album._id}" id="details">Details</a>` :'' }
               
            </div>
        </div>
    </div>
`


const catalogTemplate = ( albums, user) => html`

<section id="catalogPage">
    <h1>All Albums</h1>

    ${albums.map(x => albumTemplate(x,Boolean(user)))}

    ${albums.length == 0
        ? html` <p>No Albums in Catalog!</p>`
        : ''
    }



</section>
`;

export const catalogView = (ctx) => {

    albumservice.getAll()
        .then(albums => {
            ctx.render(catalogTemplate(albums, ctx.user));
        });

}

