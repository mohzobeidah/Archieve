$(document).ajaxStart(function () {
    AddLoader();
});

$(document).ajaxStop(function () {
    RemoveLoader();
});

var AddLoader = function (msg) {
    //console.log(msg);
    blocker_div = $('<div data-blocked-times="1" class="loading" style="z-index:99999;" id="page-loader-for-ever">' + (msg ? '<div>' + msg + '</div>' : '') + '</div>');
    if ($('#page-loader-for-ever').length == 0) {
        $('body').append(blocker_div);
    } else {
        var blockedTimes = parseInt(blocker_div.attr('data-blocked-times'));
        blocker_div.attr('data-blocked-times', blockedTimes + 1);
    }
    //console.log(blocker_div);
}

var RemoveLoader = function (msg) {
    var blocker_div = $('#page-loader-for-ever');
    var blockedTimes = parseInt(blocker_div.attr('data-blocked-times'));
    blockedTimes -= 1;

    if (blockedTimes == 0) {
        blocker_div.remove();
        //console.log('unblocked [' + elem + ']');
    } else {
        blocker_div.attr('data-blocked-times', blockedTimes);
    }
}

var toastMsg = function (option, msg, dur) {

    toastr.options = {
        "closeButton": true,
        "debug": false,
        "positionClass": "toast-bottom-center",
        "onclick": null,
        "showDuration": "1000",
        "hideDuration": "1000",
        "timeOut": "5000",
        "extendedTimeOut": "1000",
        "showEasing": "swing",
        "hideEasing": "linear",
        "showMethod": "fadeIn",
        "hideMethod": "fadeOut"
    }
    if (msg == null || msg == 'null' || msg == '' || status == "-500") {
        return;
    }
    toastr[option](msg);
}