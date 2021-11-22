// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
function selectCategory(id) {
    $("#exampleModal").modal("show");
    for (var i = 0; i < data.length; i++) {
        if (data[i].CategoryID == id)
            break;
    }
    var cat = data[i];
    console.log(cat);
    $("#txtCategoryID").val(cat.CategoryID);
    $("#txtCategoryName").val(cat.CategoryName);
    $("#txtCategoryDesc").val(cat.Description);
}