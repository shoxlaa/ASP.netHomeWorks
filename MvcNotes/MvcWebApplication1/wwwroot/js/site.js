// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
$(function () {
    let $adding = $("#add-button").unbind();


    $adding.on("click", (e) => {
        let $title = $("#title").val().toString();
        let $description = $("#description").val().toString();

        //$.get(`/Notes/GetResult`, data => {
        //    console.log(data);
        //    let object = JSON.parse(data);
        //    console.log(object);
        //    for (const element in object) {
        //        console.log(`${element} ${object[element].Title}`);
        //    }
        //});
        $.post(`/Notes/Add?title=${$title}&description=${$description}`, { title: $title, description: $description },
            data => {
                console.log($title);
                console.log($description);
                alert(data);
            });
    });


    function addNote(buffer,notes)
    {
        buffer.append(`<div class="box">
                     <div class="cont1">
                         <input  class="image" type="image" src=${movies[i].Poster.toString()}>
                     </div>
                     <div class="cont2">
                         <div class="movie-type">${movies[i].Type}</div>
                         <div class="movie-name">${movies[i].Title}</div>
                         <div class="year">${movies[i].Year}</div>
                         <input type="button" class="button-details" value="Details" >
                       
                     </div>
                 </div>`)
    }

});