import * as request from "./requester.js"


    const baseUrl='http://localhost:3030/data/cars';

export const getAll=()=>{
  return request.get(`${baseUrl}?sortBy=_createdOn%20desc`)
}

export const getOne=(carId) => request.get(`${baseUrl}/${carId}`);

export const create=(cardata)=>request.post(baseUrl,cardata);

export const edit=(carId,cardata) =>request.put(`${baseUrl}/${carId}`, cardata);

export const remove =(carId)=>request.del(`${baseUrl}/${carId}`);

export const search=(searchText)=>{

//const query=encodeURIComponent(`name LIKE "${searchText}"`)

  return  request.get(`${baseUrl}?where=year%3D${searchText}`)
}