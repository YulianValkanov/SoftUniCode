import * as userservice from '../services/userService.js'

export const logoutView=(ctx)=>{

  userservice.logout()
  .then(()=>{
      ctx.page.redirect('/')
  })
}