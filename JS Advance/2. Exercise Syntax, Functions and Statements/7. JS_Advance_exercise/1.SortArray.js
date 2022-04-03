function sort(arr, type){
let array=arr;
let comand=type;

if (comand==='asc') {
 
    array.sort((a,b)=> a-b)
}else{
    array.sort((a,b)=>b-a)
   
     
}


console.log(array); 

}


sort([14, 7, 17, 6, 8], 'desc');