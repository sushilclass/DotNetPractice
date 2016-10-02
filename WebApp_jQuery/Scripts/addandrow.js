
var addrow = function () {

    var name = $("#name").val();
    var email = $("#email").val();

    var row = {};
    row.name = $("#name").val();
    row.email = $("#email").val();
    if (validateInputs(row)) {

        var markup = "<tr><td><input type='checkbox' name='record'></td><td>" + name + "</td><td>" + email + "</td></tr>";
        $("table tbody").append(markup);
        $("#name").val(" ");
        $("#email").val(" ");
    }
};


var deleterow = function () {
    $("table tbody").find('input[name="record"]').each(function () {
        if ($(this).is(":checked")) {
            $(this).parents("tr").remove();
        }
    });
};

var validateInputs = function (row) {
    var success = true;
    var alphaRegEx = /[a-z]+/i;
    var emailRegEx = /^[a-zA-Z0-9._-]+@[a-zA-Z0-9-]+\.[a-zA-Z.]{2,5}$/i;

    //Name Validation
    if (!row.name) {
        $("#name").addClass("error");
        document.getElementById("errname").innerHTML = "Name Can't be Empty";
        success = false;
    } else {
        if (!alphaRegEx.test(row.name)) {
            $("#name").addClass("error");
            document.getElementById("errname").innerHTML = "Name is Invalid";
            success = false;
        } else {
            $("#name").removeClass("error");
           document.getElementById("errname").innerHTML = "";
           
           
        }
    }

    //Email Validation
    if (!row.email) {
        $("#email").addClass("error");
        document.getElementById("erremail").innerHTML = "Email Can't be Empty";
        success = false;
    } else {
        if (!emailRegEx.test(row.email)) {
            $("#email").addClass("error");
            document.getElementById("erremail").innerHTML = "Email is Invalid";
            success = false;
        }
        else {
            $("#email").removeClass("error");
            document.getElementById("erremail").innerHTML = "";
        }
    }

    return success;
};