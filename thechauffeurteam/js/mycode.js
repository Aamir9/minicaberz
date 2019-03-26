



$(document).ready(function () {


    var myhub = $.connection.alertHub;

    $("#btnMyMethod").on("click", function () {
        console.log("about to call myMethod");
        myhub.server.myMethod().done(function () {
            console.log("myMethod complete");
        });
    });


    myhub.client.alertMe = function (message) {
        // var x = document.getElementById("myAudio"); 

        var x = new Audio('./alarm.mp3');
       // x.play(); 
    
        x.play();
        x.loop = false;

        console.log("ALERT ME: " + message);
       // alert("working ! ............");
        //x.pause(); 
    };
});

$.connection.hub.logging = true;


var options = {
    transport: ['webSockets', 'longPolling']
};

var deferredStart = $.connection.hub.start(options);