function demo(input){

let result=[];

    let sortArr=input.sort(function(a,b){
        return a-b;
    });

    while (sortArr.length>0) {
        
    

        let first=sortArr.shift();
        let last=sortArr.pop();

        result.push(first);
        result.push(last)
        


    }
    return result; 


}

demo([1, 65, 3, 52, 48, 63, 31, -3, 18, 56]);