function attachEventsListeners(){

    let [inputField, outputField] = document.querySelectorAll('input[type="text"]');

    let fromOptin = document.querySelector('#inputUnits');
    let twOption = document.querySelector('#outputUnits');
    let convertButton = document.getElementById('convert');
    convertButton.addEventListener('click', operation)

    function operation() {
        let convert = Number(inputField.value);
        let result = 0;

        switch (fromOptin.value) {
            case 'km':
                convert *= 1000;
                break;
            case 'm':
                convert = convert;
                break;
            case 'cm':
                convert *= 0.01;
                break;
            case 'mm':
                convert *= 0.001;
                break;
            case 'mi':
                convert *= 1609.34;
                break;
            case 'yrd':
                convert *= 0.9144;
                break;
            case 'ft':
                convert *= 0.3048;
                break;
            case 'in':
                convert *= 0.0254;
                break;
        }

        switch (twOption.value) {
            case 'km':
                result=convert /= 1000;
                break;
            case 'm':
                result = convert;
                break;
            case 'cm':
                result =convert/= 0.01;
                break;
            case 'mm':
                result=convert /= 0.001;
                break;
            case 'mi':
                result=convert /= 1609.34;
                break;
            case 'yrd':
                result=convert /= 0.9144;
                break;
            case 'ft':
                result=convert /= 0.3048;
                break;
            case 'in':
                result=convert /= 0.0254;
                break;

        }
    
        outputField.value = result;
    
    }



 
}
