function AjaxPostCall(Url, DataType, InputData, FunctionNameToHandleResponse) {
    $.ajax({
        type: 'POST',
        url: Url,
        dataType: DataType,
        data: InputData,
        success: function (data) {
            reply = JSON.stringify(data);
            eval(FunctionNameToHandleResponse + '(' + reply + ');');

        }
    });
}