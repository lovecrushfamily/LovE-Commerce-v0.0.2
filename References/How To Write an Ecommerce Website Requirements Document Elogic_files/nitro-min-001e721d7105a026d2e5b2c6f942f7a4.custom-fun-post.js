jQuery(document).ready(function ($) {
   var link = 'a[href^="#"]';
    $(link).on("click", function (event) {
        event.preventDefault();
        var id  = $(this).attr('href'),
            top = ($(id).offset().top - 150);
        $('body,html').animate({scrollTop: top}, 1600);
    });
});
