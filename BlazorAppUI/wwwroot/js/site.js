function saveMessage(firstName, lastName) {
    //alert(firstName + ' ' + lastName + ' has been saved successfully!');

    document.getElementById('divServerValidations').innerText = firstName + ' ' + lastName + ' has been saved successfully!';
}

function setFocusOnElement(element) {
    element.focus();
}

function getCities() {
    var cities = ['New York', 'Los Angeles', 'Chicago', 'Houston', 'Phoenix', 'Philadelphia',
        'San Diego', 'Dallas', 'San Jose', 'Austin', 'Jacksonville', 'Fort Worth', 'Columbos',
        'Charlotte', 'Indianapolis', 'Seattle', 'Denver', 'Washington'];

    return cities;
}

function confirmDelete() {
    var x = confirm("Are you sure you want to delete the record?");
    if (x) {
        return true;
    }
    else
    {
        return false;
    }
}