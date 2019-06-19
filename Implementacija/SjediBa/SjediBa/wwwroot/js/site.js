// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
var currentEvent;

function SetCurrentEvent(jsonObj){
    currentEvent = jsonObj;
    console.log(currentEvent);
    document.getElementById('eventName').innerHTML = "Naziv događaja: " + jsonObj.Name;
    document.getElementById('eventid').value = jsonObj.EventModelId;
    SetSections();
    SetSeats();
    SetPrice();
}

function SetSections() {
    var sections_element = document.getElementById('section');
    for(var i = 0; i < currentEvent.SpaceModel.SectionModels.length; i++){
        var option = document.createElement("option");
        option.setAttribute("value", "\"" + i + "\"");
        option.text = currentEvent.SpaceModel.SectionModels[i].Name;
        sections_element.add(option);
    }
}

function SetSeats() {
    var sections_element = document.getElementById('section');
    var seat_element = document.getElementById('seat');
    console.log(sections_element.options[sections_element.selectedIndex].value);
    for(var i = seat_element.length - 1; i > 0; i--) {
        seat_element.remove(i);
    }
    if(sections_element.options[sections_element.selectedIndex].value !== ""){
        for(var i = 0; i < currentEvent.SpaceModel.SectionModels[sections_element.selectedIndex - 1].SeatModels.length; i++){
            var option = document.createElement("option");
            option.setAttribute("value", currentEvent.SpaceModel.SectionModels[sections_element.selectedIndex - 1].SeatModels[i].SeatModelId);
            option.text = currentEvent.SpaceModel.SectionModels[sections_element.selectedIndex - 1].SeatModels[i].RowSeat;
            seat_element.add(option);
        }
    }
    else{
        for(var i = seat_element.length - 1; i > 0; i--){
            seat_element.remove(i);
        }
    }
}

function SetPrice() {
    var sections_element = document.getElementById('section');
    if(sections_element.options[sections_element.selectedIndex].value !== "") {
        document.getElementById("seatPrice").innerHTML = "Cijena: " + currentEvent.SpaceModel.SectionModels[sections_element.selectedIndex - 1].SeatPrices + "KM";
    }
    else{
        document.getElementById("seatPrice").innerHTML = "Morate odabrati sektor da biste vidjelli cijenu!";
    }
}