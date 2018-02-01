function handleAjax(url, data, successCallback) {
    $.ajax({
        url: url,
        type: "POST",
        contentType: "application/json",
        data: data
    }).done(function (args) {
        successCallback(args);
    }).fail(function (args) {
        console.log(args);
    });
}

function search(searchTerm) {
    handleAjax("/Search",JSON.stringify(searchTerm),renderResult);
}

function renderResult(result) {
}
