$(document).ready(function() {
	var emailPattern = /\b[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}\b/;
		
}); 

$("#reservation_form").submit( 
        function(event) {
            var isValid = true;
            
            var emailPattern = /\b[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}\b/;
            var email = $("#email").val().trim();
            if (email == "") { 
                $("#email").next().text("This field is required.");
                isValid = false;
            }
            else if ( !emailPattern.test(email) ) {
                $("#email").next().text("Must be a valid email address.");
                isValid = false;
            }
            else {
                $("#email").next().text("");
            }
            $("#email").val(email);
            
            var arrival_date = $("#arrival_date").val().trim();
            
            if (arrival_date == "") {
                $("#arrival_date").next().text("This field is required.");
                isValid = false;
            }
            else {
                $("#arrival_date").next().text("");
            }
            $("#arrival_date").val(arrival_date);
            
            
            var nights = $("#nights").val().trim();
            
            if (nights == "") {
                $("#nights").next().text("This field is required.");
                isValid = false;
            }
            else if (isNaN(nights)){
                $("#nights").next().text("Must be a number.");
                isValid = false;
            }
            else {
                $("#nights").next().text("");
            }
            $("#nights").val(nights);
            
            
            
            var name = $("#name").val().trim();
            
            if (name == "") {
                $("#name").next().text("This field is required.");
                isValid = false;
            }
            else {
                $("#name").next().text("");
            }
            $("#name").val(name);
            
            
            var phone = $("#phone").val().trim();
            
            if (phone == "") {
                $("#phone").next().text("This field is required.");
                isValid = false;
            }
            else {
                $("#phone").next().text("");
            }
            $("#phone").val(phone);
            
            
            
            
            if (isValid == false) { event.preventDefault(); }
        } 
    ); 