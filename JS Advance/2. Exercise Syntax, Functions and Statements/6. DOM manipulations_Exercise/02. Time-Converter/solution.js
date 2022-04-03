function attachEventsListeners() {

    console.log('TODO:...');

    let daysElement = document.getElementById('days');
    let hoursElement = document.getElementById('hours');
    let minutesElement = document.getElementById('minutes');
    let secondsElement = document.getElementById('seconds');


    let daysButtonElement = document.getElementById('daysBtn');
    let hoursButtonElement = document.getElementById('hoursBtn');
    let minutesButtonElement = document.getElementById('minutesBtn');
    let secondsButtonElement = document.getElementById('secondsBtn');

    daysButtonElement.addEventListener('click', function (e) {
        let daysNumber = Number(daysElement.value);

        let hoursNumber = Number(daysNumber * 24);
        let minutesNumber = Number(hoursNumber * 60);
        let secondsNumber = Number(minutesNumber * 60);

        daysElement.value=daysNumber;
        hoursElement.value=hoursNumber;
        minutesElement.value=minutesNumber;
        secondsElement.value=secondsNumber;
    });

    hoursButtonElement.addEventListener('click', function (e) {
        
        let hoursNumber = Number(hoursElement.value);

        let daysNumber = Number(hoursNumber/24);
        let minutesNumber = Number(hoursNumber * 60);
        let secondsNumber = Number(minutesNumber * 60);

        daysElement.value=daysNumber;
        hoursElement.value=hoursNumber;
        minutesElement.value=minutesNumber;
        secondsElement.value=secondsNumber;
    });

    minutesButtonElement.addEventListener('click', function (e) {
        let minutesNumber = Number(minutesElement.value);

        let hoursNumber = Number(minutesNumber/60);

        let daysNumber = Number(hoursNumber/24);
    
        let secondsNumber = Number(minutesNumber * 60);

        daysElement.value=daysNumber;
        hoursElement.value=hoursNumber;
        minutesElement.value=minutesNumber;
        secondsElement.value=secondsNumber;
    });

    secondsButtonElement.addEventListener('click', function (e) {

        let secondsNumber = Number(secondsElement.value);

        let minutesNumber = Number(secondsNumber/60);

        let hoursNumber = Number(minutesNumber/60);

        let daysNumber = Number(hoursNumber/24);
    
     

        daysElement.value=daysNumber;
        hoursElement.value=hoursNumber;
        minutesElement.value=minutesNumber;
        secondsElement.value=secondsNumber;
    });





}