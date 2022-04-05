import { html } from "../../node_modules/lit-html/lit-html.js";

import * as userservice from '../services/userService.js'

const loginTemplate=(submitHandler)=>html`

<!-- Login Page -->
<section id="login">
    <div class="container">
        <form @submit=${submitHandler} id="login-form" action="#" method="post">
            <h1>Login</h1>
            <p>Please enter your credentials.</p>
            <hr>

            <p>Username</p>
            <input placeholder="Enter Username" name="username" type="text">

            <p>Password</p>
            <input type="password" placeholder="Enter Password" name="password">
            <input type="submit" class="registerbtn" value="Login">
        </form>
        <div class="signin">
            <p>Dont have an account?
                <a href="/register">Sign up</a>.
            </p>
        </div>
    </div>
</section>
`;

export const loginView=(ctx)=>{

    const submitHandler=(e)=>{
        e.preventDefault();
        const {username, password}=Object.fromEntries(new FormData(e.currentTarget));

        if (!username || !password) {
            alert('Email or password feelds are empty');
            return;
        }

        userservice.login(username,password)
        .then(()=>{
          ctx.page.redirect('/catalog');
        })
        .catch(err=>{
            alert(err)
        })
    }
    ctx.render(loginTemplate(submitHandler))

}
    

