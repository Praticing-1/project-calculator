var firstNumber = document.getElementById("n1")
var secondNumber = document.getElementById("n2")
var result = document.getElementById("result")

//Create functions
function sumNumbers(firstNumber,secondNumber){
    return parseInt(firstNumber.value) + parseInt(secondNumber.value)
}

function subtractNumbers(firstNumber,secondNumber){
    return parseInt(firstNumber.value) - parseInt(secondNumber.value)
}

function multiplicateNumbers(firstNumber,secondNumber){
    return parseInt(firstNumber.value) * parseInt(secondNumber.value)
}

function divisionNumbers(firstNumber,secondNumber){
    return parseInt(firstNumber.value) / parseInt(secondNumber.value)
}

//Click Button
document.getElementById("addiction").addEventListener("click", function () {
    result.innerHTML=(sumNumbers(firstNumber, secondNumber))
})

document.getElementById("subtraction").addEventListener("click", function () {
    result.innerHTML=(subtractNumbers(firstNumber, secondNumber))
})

document.getElementById("multiplicate").addEventListener("click", function () {
    result.innerHTML=(multiplicateNumbers(firstNumber, secondNumber))
})

document.getElementById("division").addEventListener("click", function () {
    result.innerHTML=(divisionNumbers(firstNumber, secondNumber))
})
