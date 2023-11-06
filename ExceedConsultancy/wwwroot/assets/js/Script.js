

$(document).on('click', '.deleteBtn', function (e) {
    e.preventDefault();
    const itemId = $(this).data('item-id');
    const itemDelete = $(this).data('delete-type');

    $.ajax({
        url: `/CPanel/Delete/${itemDelete}/${itemId}`,
        type: 'POST',
        success: function () {
            window.location.reload();
        },
    });
});

