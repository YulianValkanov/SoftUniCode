function getArticleGenerator(articles) {
    
let divElement=document.getElementById('content');

let articlesArr=articles;



return()=>{

    if (articlesArr.length==0) {
       return;
    }

    let a=document.createElement('article');
    a.textContent=articlesArr.shift();;
    divElement.appendChild(a);

        return articlesArr;
}
    
   


}
