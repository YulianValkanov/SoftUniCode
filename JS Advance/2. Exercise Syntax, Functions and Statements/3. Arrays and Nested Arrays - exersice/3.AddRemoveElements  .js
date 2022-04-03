function demo(input){

    sum=0;
    let currentArr=[]
    for (const comand of input) {
        
        if(comand=="add"){
            sum+=1;
            currentArr.push(sum)
          
        }else{
            currentArr.pop();
            sum+=1;
        }
       

    }

  

  if(currentArr.length==0){
      console.log('Empty');
  }
  else  {
      for (const element of currentArr) {
          console.log(element);
      }
  }

}

demo(['add', 
'add', 
'remove', 
'add', 
'add']

);