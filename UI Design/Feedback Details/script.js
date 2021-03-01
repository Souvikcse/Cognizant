window.onload = () => {
    var addbtn = document.getElementById('create');
    var viewbtn = document.getElementById('view');
    var result = document.getElementById('result');
    var feedback = document.getElementById('feedback');
    var arr = [];

    function addFeedback(){
        // console.log(feedback.value.length);
        arr.push(feedback.value.trim());
        feedback.value = "";
        result.innerHTML = "<h2>Feedback Details</h2> <h4>Successfully Added Feedback Details!</h4>";
        result.style.display = "block";
    }
    function displayFeedback(){
        // var count = 1;
        result.innerHTML = "<h2>Feedback Details</h2> <p>";
        arr.forEach((item, index) => {
            result.innerHTML += `Feedback ${index+1} <br> ` + item + `<br>`;
        });
        arr = [];
    }

    addbtn.addEventListener('click', ()=>{
        if (feedback.value.trim() !== "")    
            addFeedback();
    });
    viewbtn.addEventListener('click', ()=>{
        displayFeedback();
    })

}