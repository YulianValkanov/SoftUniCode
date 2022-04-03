function solve() {
  let textInptElement = document.getElementById('text');
  let namingParametre = document.getElementById('naming-convention');
  let resultElement = document.getElementById('result');

  let textInput = textInptElement.value;
  let comandInput = namingParametre.value;

  let result = 'Error!';

  if (comandInput == 'Camel Case') {

    let textArray = textInput.toLowerCase().split(" ");
    result = "";

    for (let index = 0; index < textArray.length; index++) {

      if (index === 0) {
        result += textArray[index][0];
        result += textArray[index].substring(1);
        continue;
      }
      result += textArray[index][0].toUpperCase();
      result += textArray[index].substring(1);
    }


  }

  if (comandInput == 'Pascal Case') {

    let textArray = textInput.toLowerCase().split(" ");
    result = "";

    for (let index = 0; index < textArray.length; index++) {

      result += textArray[index][0].toUpperCase();
      result += textArray[index].substring(1);
    }


  }


  resultElement.textContent = result;
}