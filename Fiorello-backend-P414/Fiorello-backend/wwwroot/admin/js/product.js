$(document).ready(function () {
    

    $(document).on("click", ".images button", function () {

        let productImageId = $(this).attr("data-id");

        let removedElem = $(this).parent();

        let data = { id: productImageId };

        $.ajax({
            url: "/admin/product/deleteProductImage",
            type: "Post",
            data: data,
            success: function () {
                $(removedElem).remove();
            }

        })

    })
})