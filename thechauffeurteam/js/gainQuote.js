
$(document).ready(function () {

    $('.iconpick ,.pck').click(function () {

        $('#from_places').val('');
        $('#GetQuote').show();
        $('#BookNow').hide();
      
        $('#LoginPopShow').hide();
        $('#priceMileMain').hide();
        $('#Prices').html('');

 });


    $('.icondrop ,.drp').click(function () {

        $('#to_places').val('');
        $('#GetQuote').show();
        $('#BookNow').hide();
        $('#LoginPopShow').hide();
        $('#priceMileMain').hide();
        $('#Prices').html('');

   });



});