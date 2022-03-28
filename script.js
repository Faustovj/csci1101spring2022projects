window.addEventListener("load", function ()
{
  
let counter = 0;

// camelcase
function buttonclicked() 
{
  clickcounter++; //incriment the counter

  // to update the 0
  let clickedCounterElement = document.getElementById(clickcounter);

  clickedCounterElement.innerHTML = "Clicked " + counter + "times.";
}

let clickedButtonElement = document.getElementById("clickbutton");


clickedButtonElement.addEventListener("click", buttonclicked);
});