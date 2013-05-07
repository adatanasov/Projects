/* Refactor the following examples to produce code with well-named identifiers in JavaScript
function _ClickON_TheButton( THE_event, argumenti) {
  var moqProzorec= window;
  var brauzyra = moqProzorec.navigator.appCodeName;
  var ism=brauzyra=="Mozilla";
  if(ism)  {
    alert("Yes");  }
  else
  {
    alert("No");  }
} */

function printIsCurrentBrowserMozilla() {
    var currentBrowser = window.navigator.appCodeName;
    if (currentBrowser === "Mozilla") {
        alert("The current browser is Mozilla");
    } else {
        alert("The current browser is not Mozilla");
    }
}