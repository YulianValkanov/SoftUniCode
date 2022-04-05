

export const saveUser = (user) => {
    if (user.accessToken) {
        localStorage.setItem('user', JSON.stringify(user))
    }
}

export const deleteUser=()=>{
localStorage.removeItem('user')

}

export const getToken=()=>{
    return getUser()?.accessToken;
}

export const getUser = () => {
    let serializeduser = localStorage.getItem('user');
    if (serializeduser) {
        let user = JSON.parse(serializeduser);

        return user;
    }
}