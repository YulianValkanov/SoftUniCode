

function demo(fruit, weight, price){

let fruitTupe=fruit;
let weightTypeKilogram=weight/1000;
let priceForKilogram=price;

let tolalPrice=weightTypeKilogram*priceForKilogram;

console.log(`I need ${tolalPrice.toFixed(2)} to buy ${weightTypeKilogram.toFixed(2)} kilograms ${fruitTupe}.`);
}

demo('apple',2500,2,5)