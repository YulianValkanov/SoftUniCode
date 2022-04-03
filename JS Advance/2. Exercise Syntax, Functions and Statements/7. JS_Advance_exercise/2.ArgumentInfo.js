function convert() {

    let obj = {};

    Array.from(arguments).forEach(el => {

        let type = typeof el;

        console.log(`${type}: ${el}`);

        if (!obj[type]) {
            obj[type] = 0;
        }

        obj[type]++;
    });

   let x= Object.keys(obj).sort((a,b)=>{
       return b-a;
    });


for (let index = 0; index < x.length; index++) {
   
    console.log(`${x[index]} = ${obj[x[index]]}`);
}


}








convert({ name: 'bob'}, 3.333, 9.999);