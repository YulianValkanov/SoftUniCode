import { html } from "../../node_modules/lit-html/lit-html.js";

import * as albumservice from '../services/albumService.js';

import { albumIsInvalid } from '../utils/validators.js'

const editTemplate = (album, submitHandler) => html`
<!--Edit Page-->
        <section class="editPage">
            <form @submit=${submitHandler}>
                <fieldset>
                    <legend>Edit Album</legend>

                    <div class="container">
                        <label for="name" class="vhide">Album name</label>
                        <input id="name" name="name" value=${album.name} class="name" type="text" value="In These Silent Days">

                        <label for="imgUrl" class="vhide">Image Url</label>
                        <input id="imgUrl" name="imgUrl" value=${album.imgUrl} class="imgUrl" type="text" >

                        <label for="price" class="vhide">Price</label>
                        <input id="price" name="price" value=${album.releaseDate} class="price" type="text">

                        <label for="releaseDate" class="vhide">Release date</label>
                        <input id="releaseDate" name="releaseDate" value=${album.artist} class="releaseDate" type="text">

                        <label for="artist" class="vhide">Artist</label>
                        <input id="artist" name="artist" class="artist" type="text" value="Brandi Carlile">

                        <label for="genre" class="vhide">Genre</label>
                        <input id="genre" name="genre" class="genre" value=${album.genre} type="text" >

                        <label for="description" class="vhide">Description</label>
                        <textarea name="description" class="description" rows="10"
                            cols="10">${album.description}</textarea>

                        <button class="edit-album" type="submit">Edit Album</button>
                    </div>
                </fieldset>
            </form>
        </section>
`;

export const editView = (ctx) => {

const albumId=ctx.params.albumId;

    const submitHandler = (e) => {

        e.preventDefault();

        let albumdata = Object.fromEntries(new FormData(e.currentTarget));

        if (albumIsInvalid(albumdata)) {
            alert('All fields should be filled')
            return;
        };

        albumservice.edit(albumId, albumdata).then(ctx.page.redirect(`/albums/${albumId}`))
       
    }


    albumservice.getOne(albumId)
        .then(album => {
            ctx.render(editTemplate(album, submitHandler))
        })
}