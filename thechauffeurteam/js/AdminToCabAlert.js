

$(document).ready(function () {


    var myhub = $.connection.alertHub;

   
    myhub.client.cabAlert = function () {


        var x = new Audio('/alarm.mp3');
        
        x.play();
        x.loop = false;

        var notification = alertify.notify('New Job Booked', 'success', 5, function () { console.log('dismissed'); window.location.reload(true); });
    };
});

$.connection.hub.logging = true;


var options = {
    transport: ['webSockets', 'longPolling']
};

var deferredStart = $.connection.hub.start(options);




