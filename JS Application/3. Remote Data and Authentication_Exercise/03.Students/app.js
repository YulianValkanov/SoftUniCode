async function solve() {

    console.log('teds');

    let url = 'http://localhost:3030/jsonstore/collections/students';

    const table = document.querySelector('#results tbody');

    let response = await fetch(url);

    let data = await response.json();



    for (const el of Object.values(data)) {

        let firstName = el.firstName;
        let lastName = el.lastName;
        let facultyNumber = el.facultyNumber;
        let grade = Number(el.grade);
        let id = el._id;

        let creteTr = document.createElement('tr');

        let firstCell = creteTr.insertCell(0);
        firstCell.innerText = firstName;

        let lastCell = creteTr.insertCell(1);
        lastCell.innerText = lastName;


        let facultyCell = creteTr.insertCell(2);
        facultyCell.innerText = facultyNumber;

        let gradeCell = creteTr.insertCell(3);
        gradeCell.innerText = grade;



        table.appendChild(creteTr)


    }

    let buttonSubmit = document.getElementById('submit');

    buttonSubmit.addEventListener('click', onClickSubmit)

    async function onClickSubmit(ev) {

        ev.preventDefault();

        let firstNameInput = document.getElementsByName('firstName')[0];
        let LastInput = document.getElementsByName('lastName')[0];
        let FacultyInput = document.getElementsByName('facultyNumber')[0];
        let GradeInput = document.getElementsByName('grade')[0];

        if (isNaN(FacultyInput.value) || isNaN(GradeInput.value)) {
            return alert('Wrong input value');
        }

        if (FacultyInput.value!=''
        && GradeInput.value!=''
        && firstNameInput.value!=''
        &&LastInput.value!=''){
            obj={
                firstName: firstNameInput.value,
                lastName: LastInput.value,
                facultyNumber: FacultyInput.value,
                grade: GradeInput.value,
    
            }
    
            const response= await fetch(url,{ 
                method: 'post',
                headers: {'Content-Type': 'application/json'},
                body: JSON.stringify(obj)
    
            });
    
            let creteTr = document.createElement('tr');
    
            let firstCell = creteTr.insertCell(0);
            firstCell.innerText = firstNameInput.value;
    
            let lastCell = creteTr.insertCell(1);
            lastCell.innerText = LastInput.value;
    
    
            let facultyCell = creteTr.insertCell(2);
            facultyCell.innerText = FacultyInput.value;
    
            let gradeCell = creteTr.insertCell(3);
            gradeCell.innerText = GradeInput.value;
            
    
            table.appendChild(creteTr)
    
            firstNameInput.value='';
            LastInput.value='';
            FacultyInput.value='';
            GradeInput.value='';


        }

      
    }


}

solve();