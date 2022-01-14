// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
$(document).ready(function () {
    $.ajax({
        url: "/api/products",
        success: function name(data) {
            if (data.length > 0) {
                data.forEach(product => {
                    $("#producttable tbody").append(
                        `<tr>
                            <th scope="row">${product.code}</th>
                            <td>${product.designation}</td>
                            <td>${product.quantity}</td>
                            <td>${product.unitPrice}</td>
                        </tr>`
                    )
                });
            } else {
                $("#producttable tbody").append(
                    `<tr>
                        <td colspan="4">Database is empty</td>
                    </tr>`
                )
            }
        },
      });
    console.log()
});
