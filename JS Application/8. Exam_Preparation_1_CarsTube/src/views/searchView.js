import { html  } from "../../node_modules/lit-html/lit-html.js";


import * as albumservice from '../services/currentService.js'

import {carTemplate} from '../views/catalogView.js'

const searchTemplate=(searchHendler,cars, isLogged)=>html `

<!-- Search Page -->
<section id="search-cars">
    <h1>Filter by year</h1>

    <div class="container">
        <input id="search-input" type="text" name="search" placeholder="Enter desired production year">
        <button @click=${searchHendler} class="button-list">Search</button>
    </div>




    <h2>Results:</h2>
    <div class="listings">

        <!-- Display all records -->
       
        ${cars.map(x=>carTemplate(x))}

        ${cars.length==0
        ? html `
        <!-- Display if there are no matches -->
        <p class="no-cars"> No results.</p>
        `
        : ''
        }
        


    </div>
</section>
`

export const searchView=(ctx)=>{
const searchHendler=(e)=>{
    let searchElement=document.getElementById('search-input')
    
    albumservice.search(searchElement.value)
    .then(cars=>{
        const isLogged=Boolean(ctx.user)
        ctx.render(searchTemplate(searchHendler,cars, isLogged))
    })
   
};

ctx.render(searchTemplate(searchHendler, []))
}