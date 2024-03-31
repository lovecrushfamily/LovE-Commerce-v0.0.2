jQuery('a[href^="#"]:not(.btn)').on('click', function (e) {
    e.preventDefault();
    var href_url = jQuery(this).attr('href');
    jQuery('html,body').animate({
        scrollTop: (jQuery(href_url).offset().top - 50)
    });
});