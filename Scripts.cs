const form = document.getElementById("messageForm");
const result = document.getElementById("result");

form.addEventListener("submit", function(event) {
    event.preventDefault();

    if (form.checkValidity()) {
        result.textContent = "Customer message submitted successfully!";
        form.reset();
    } else {
        form.reportValidity();
        result.textContent = "Please correct the errors.";
    }
});
