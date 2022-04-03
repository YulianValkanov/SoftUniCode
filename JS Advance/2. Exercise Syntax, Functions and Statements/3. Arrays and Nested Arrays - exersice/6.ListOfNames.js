function demo(input) {
    let arr = input;

  let result= arr.sort(function(a,b){
       return a.localeCompare(b);
   });

   let i=1;
for (const element of result) {
    console.log(`${i}.`+element);
    i++;   
}

 

}

demo(["John", "Bob", "Christina", "Ema"]);