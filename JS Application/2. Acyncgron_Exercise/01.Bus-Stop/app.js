function getInfo() {
  
    
    let StopIdElement=document.getElementById("stopId");
    let stopId=StopIdElement.value;
   
    let stopNameElement=document.getElementById('stopName');
    let bussesElement=document.getElementById('buses');
    
    stopNameElement.textContent='';
    while (bussesElement.hasChildNodes()) {
        bussesElement.removeChild(bussesElement.lastChild);
    }
    
    let webs='http://localhost:3030/jsonstore/bus/businfo/'+stopId;

    
    fetch(webs)
    .then(res=>res.json())
    .then(data=>{
        stopNameElement.textContent=data['name'];
        
        Object.keys(data['buses']).forEach(key => {
    
    let createLiElement=document.createElement('li');
    createLiElement.textContent= `Bus ${key} arrives in ${data['buses'][key]} minutes`;
    bussesElement.appendChild(createLiElement);
         
    StopIdElement.value='';
          });

            
    })
    .catch(err=>{

    stopNameElement.textContent='Error';
    })
}