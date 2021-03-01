
var pA = document.getElementById('principalAmount');
var rate = document.getElementById('interestRate');
var tenure = document.getElementById('tenure');

function calculateEMI() {
    var P = Number(pA.value);
    var R = (Number(rate.value)/100)/12;
    var N = Number(tenure.value);

    var EMI = P * R * (Math.pow(1+R, N)/(Math.pow(1+R, N)-1));

    document.getElementById('result').innerHTML = "EMI is Rs. " + EMI.toFixed(2);
    return false;
}