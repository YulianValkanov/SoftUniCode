function demo(input){

let sortArr=input.sort(function(a,b){
    return a.length-b.length || a.localeCompare(b);
});

for (const element of sortArr) {
    console.log(element);
}

}

demo(['test', 
'Deny', 
'omen', 
'Default']
);