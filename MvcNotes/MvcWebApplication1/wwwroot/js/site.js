// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
$(function () {
    let $adding = $("#add-button").unbind();



    $adding.on("click", (e) => {
        let $title = $("#title-box").val().toString();
        let $description = $("#description-box").val().toString();

        //$.get(`/Notes/GetResult`, data => {
        //    console.log(data);
        //    let object = JSON.parse(data);
        //    console.log(object);
        //    for (const element in object) {
        //        console.log(`${element} ${object[element].Title}`);
        //    }
        //});
        console.log($title);
        console.log($description);
        $.post(`/Notes/Add?title=${$title}&description=${$description}`), { title: $title, description: $description },
            data => { alert(data)  };


    });

});