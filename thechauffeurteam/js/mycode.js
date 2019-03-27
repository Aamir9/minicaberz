

$(document).ready(function () {

   
    var myhub = $.connection.alertHub;

    $("#btnMyMethod").on("click", function () {
        console.log("about to call myMethod");
        myhub.server.myMethod().done(function () {
            console.log("myMethod complete");

            alertify.alert('Ready!');
            alert("working ! ............");

        });
    });


    myhub.client.alertMe = function () {

       // var x = document.getElementsByClassName("myAudio"); 

        var x = new Audio('/alarm.mp3');
       // $('.myAudio').play();
         x.play();
        x.loop = false;

        var notification = alertify.notify('New Job Booked', 'success', 5, function () { console.log('dismissed'); window.location.reload(true); });


        console.log("ALERT ME: " );

        //alertify.alert('Ready!');
     //   alert("working ! ............");
        //x.pause(); 
    };
});

$.connection.hub.logging = true;


var options = {
    transport: ['webSockets', 'longPolling']
};

var deferredStart = $.connection.hub.start(options);




