function demo(steps,stepMeters,speed){

let studentDistance=(Number)(steps)*(Number)(stepMeters)/1000;

let studentBreakMinutes=(Math.floor(studentDistance/0.5))/60;

let studentSpeed=Number(speed);

let time=studentDistance/studentSpeed+studentBreakMinutes;

let hour=Math.floor(time).toString().padStart(2,'0');
let minutes=Math.floor(time*60).toString().padStart(2,'0');
let seconds=((time*60-minutes)*60).toFixed(0).toString().padStart(2,'0');

console.log(`${hour}:${minutes}:${seconds}`);

}

demo(2564, 0.70, 5.5);