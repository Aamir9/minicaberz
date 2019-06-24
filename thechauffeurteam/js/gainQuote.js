
$(document).ready(function () {

    $('.iconpick').click(function () {

        $('#from_places').val('');
        $('#GetQuote').show();
        $('#BookNow').hide();
      
        $('#LoginPopShow').hide();
        $('#priceMileMain').hide();
        $('#Prices').html('');

 });


    $('.icondrop').click(function () {

        $('#to_places').val('');
        $('#GetQuote').show();
        $('#BookNow').hide();
        $('#LoginPopShow').hide();
        $('#priceMileMain').hide();
        $('#Prices').html('');

   });



});