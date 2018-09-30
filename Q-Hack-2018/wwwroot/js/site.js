// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your Javascript code.



function testFunction(event) {
    let btn = event.target;
    let btnsib = btn.nextElementSibling.innerHTML;
    console.log("sib: ", btnsib.classList);
    console.log("btn: ", btn.classList);
    // if(btn.classList.contain("btn-section--active"){
        
    // })

}
// $(window).on("load", function () {
//     // Handler when all assets (including images) are loaded
// });

document.addEventListener("DOMContentLoaded", function () {



});