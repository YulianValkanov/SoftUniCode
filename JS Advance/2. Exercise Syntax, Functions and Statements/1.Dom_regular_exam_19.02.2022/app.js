function solve() {
  

   let firstNameElement=document.getElementById('fname');
   let lastNameElement=document.getElementById('lname');
   let emailElement=document.getElementById('email');
   let birthElement=document.getElementById('birth');
   let posotionElement=document.getElementById('position');
   let salaryElement=document.getElementById('salary');

   let hireButton=document.getElementById('add-worker');

   let tableBodyElement=document.getElementById('tbody');

   let sumBudjetElement=document.getElementById('sum');

   let sum=0;

   hireButton.addEventListener('click',(e)=>{
    e.preventDefault();

      let firstName=firstNameElement.value;
      let lastName=lastNameElement.value;
      let email=emailElement.value;
      let birth=birthElement.value;
      let position=posotionElement.value;
      let salary=Number(salaryElement.value);

      if (firstName==''||
      lastName==''||
      email==''||
      birth==''||
      position==''||
      salary=='') {
          return;
      }

        let createTRelement=document.createElement('tr');

        let createTDfirstEl=document.createElement('td');
        createTDfirstEl.textContent=firstName;

        let createTDlastEl=document.createElement('td');
        createTDlastEl.textContent=lastName;

        let createTDemailEl=document.createElement('td');
        createTDemailEl.textContent=email;

        let createTDbirthEl=document.createElement('td');
        createTDbirthEl.textContent=birth;

        let createTDpositinoEl=document.createElement('td');
        createTDpositinoEl.textContent=position;

        let createTDsalaryEl=document.createElement('td');
        createTDsalaryEl.textContent=salary;

        let createTDbutonsEl=document.createElement('td');
        
        let createButonFired=document.createElement('button');
        createButonFired.textContent='Fired';
        createButonFired.className='fired'; 

        let createButonEdit=document.createElement('button');
        createButonEdit.textContent='Edit';
        createButonEdit.className='edit';

        createTDbutonsEl.appendChild(createButonFired);
        createTDbutonsEl.appendChild(createButonEdit);




       createTRelement.appendChild(createTDfirstEl);
       createTRelement.appendChild(createTDlastEl);
       createTRelement.appendChild(createTDemailEl);
       createTRelement.appendChild(createTDbirthEl);
       createTRelement.appendChild(createTDpositinoEl);
       createTRelement.appendChild(createTDsalaryEl);
       createTRelement.appendChild(createTDbutonsEl);

       tableBodyElement.appendChild(createTRelement);


       firstNameElement.value='';
       lastNameElement.value='';
       emailElement.value='';
       birthElement.value='';
       posotionElement.value='';
       salaryElement.value='';

       sum+=salary;
       sumBudjetElement.textContent=sum.toFixed(2);


       createButonEdit.addEventListener('click',(e)=>{
           console.log("hi");

           firstNameElement.value=firstName;
           lastNameElement.value=lastName;
           emailElement.value=email;
           birthElement.value=birth;
           posotionElement.value=position;
           salaryElement.value=salary;

           sum-=salary;
           sumBudjetElement.textContent=sum.toFixed(2);

          
        e.target.parentElement.parentElement.remove();

       });

       createButonFired.addEventListener('click',(e)=>{
          
        sum-=salary;
        sumBudjetElement.textContent=sum.toFixed(2);

        e.target.parentElement.parentElement.remove();

       })


   })
   

}
solve()