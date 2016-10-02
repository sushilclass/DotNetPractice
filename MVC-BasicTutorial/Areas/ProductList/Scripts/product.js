$(document).ready(function () {
    $("#CategoryType").change(function () {
        $("#tblProducts tbody tr").remove();
        {
            AjaxPostCall('/ProductList/Home/getProductsByCategory', 'json', { id: $("#CategoryType").val() }, 'loadProducts');
            return false;
        }
    });

});

function loadProducts(products)
{

    $.each(products, function (i, item) {
        var rows = "<tr>"
        + "<td class='prtoducttd'>" + item.ProductID + "</td>"
        + "<td class='prtoducttd'>" + item.ProductName + "</td>"
        + "<td class='prtoducttd'>" + item.QuantityPerUnit + "</td>"
        + "<td class='prtoducttd'>" + item.UnitPrice + "</td>"
        + "<td class='prtoducttd'>" + item.UnitsInStock + "</td>"
        + "<td class='prtoducttd'>" + item.ReorderLevel + "</td>"
        + "</tr>";
        $('#tblProducts tbody').append(rows);
    });
}