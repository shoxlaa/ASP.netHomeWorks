// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
$(function () {
    let $adding = $("#add-button").unbind();

    $adding.on("click", (e) => {
        let $title = $("#title").val().toString();
        let $description = $("#description").val().toString();
        let $listOfNotes = $("#list");
        $.post(`/Notes/Add?title=${$title}&description=${$description}`, { title: $title, description: $description },
            data => {
                console.log($title);
                console.log($description);
                //alert(data);
            });

        $.get(`/Notes/GetResult`, data => {
            //console.log(data);
            let object = JSON.parse(data);
            //console.log(object);
            for (const element in object) {
                let objElement = object[element];
                $listOfNotes.empty();
                $listOfNotes.append(`<li>
            <div>${object[element].Title}</div>
<div>${object[element].Description}</div>
<div>${object[element].Datetime}</div>
<div>${object[element].Tags}</div>
                        </li>`)
            }
           
        });
        
    });


 

});