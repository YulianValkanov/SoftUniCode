function solve() {

   document.querySelector('#btnSend').addEventListener('click', onClick);




   function onClick() {

      let textArr = JSON.parse(document.querySelector('#inputs textarea').value);

      let bestResturantElement = document.querySelector('#bestRestaurant p');

      let workersElement = document.querySelector('#workers p');

      let allRestorants = [];


      for (const resturants of textArr) {

         let currentArr = resturants.split(" - ");

         let resturantName = currentArr[0];

         let resturantPersonal = [];

         let personalArr = currentArr[1].split(', ');

         let sumOfSalarys = 0;

         for (const currentPerson of personalArr) {

            let personSalary = currentPerson.split(' ');
            let personName = personSalary[0];
            let currentSalary = Number(personSalary[1]);


            let person = {
               name: personName,
               salary: currentSalary
            };

            sumOfSalarys += currentSalary;

            resturantPersonal.push(person);
         };

        

         let avarageSalary = sumOfSalarys / resturantPersonal.length;



         let resturant = {
            name: resturantName,
            personal: resturantPersonal,
            avaragePersonalSalary: avarageSalary

         };


         allRestorants.push(resturant);

      }

      // let bestResturant=allRestorants.reduce((a,b)=>Math.max(a.avaragePersonalSalary,b.avaragePersonalSalary));

      allRestorants.sort((a, b) => b.avaragePersonalSalary - a.avaragePersonalSalary);

      let bestResturant = allRestorants[0];

      console.log(bestResturant);

      bestResturantElement.textContent = `Name: ${bestResturant.name} Average Salary: ${bestResturant.avaragePersonalSalary.toFixed(2)} Best Salary: ${(bestResturant.personal.sort((a,b)=>b.salary-a.salary)[0].salary).toFixed(2)}`;

      let result='';
      for (const personal of bestResturant.personal.sort((a,b)=>b.salary-a.salary)) {
         
         result+=`Name: ${personal.name} With Salary: ${personal.salary} `
      }

      workersElement.textContent = result;
         
     

   }





    workersElement.textContent = bestAllPersons;







}