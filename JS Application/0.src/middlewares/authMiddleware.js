import * as autservice from '../services/authService.js'

export const authMiddleware=(ctx,next)=>{

ctx.user=autservice.getUser();

next();
}