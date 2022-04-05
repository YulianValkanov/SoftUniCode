import { html  } from "../../node_modules/lit-html/lit-html.js";


import * as albumservice from '../services/albumService.js'

import {albumTemplate} from '../views/catalogView.js'

const searchTemplate=(searchHendler,albums, isLogged)=>html `
<!--Search Page-->
<section id="searchPage">
    <h1>Search by Name</h1>

    <div class="search">
        <input id="search-input" type="text" name="search" placeholder="Enter desired albums's name">
        <button class="button-list" @click=${searchHendler}>Search</button>
    </div>

    <h2>Results:</h2>

      

        ${albums.length==0 
            ?
            html`
            <!--If there are no matches-->
              <p class="no-result">No result.</p>
            `
            : 
            albums.map(x=>albumTemplate(x,isLogged))
           
        }
       
    </div>
</section>
`

export const searchView=(ctx)=>{
const searchHendler=(e)=>{
    let searchElement=document.getElementById('search-input')
    
    albumservice.search(searchElement.value)
    .then(albums=>{
        const isLogged=Boolean(ctx.user)
        ctx.render(searchTemplate(searchHendler,albums, isLogged))
    })
   
};

ctx.render(searchTemplate(searchHendler, []))
}