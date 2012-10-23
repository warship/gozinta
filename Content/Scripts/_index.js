// js responses on index page

$(document).ready(function () {
    $("#form-search").submit(function(event) {
        event.preventDefault(); 

        var $form = $( this ),
            num = $form.find( 'input[name="isbn"]' ).val(),
            url = $form.attr( 'action' );

        $.post(url, { isbn: num },
          function (data) {
              $("#query").empty().append(num);
          });
    });

    $('#help').popover({ trigger: "hover", title: "Type in your textbook's ISBN #", content: "<img src=\"../Content/Images/isbn-where.gif\" />" });
});