var DownloadFiles = [];
var myfile = [];
var fileListfinal = [];
function deleteTempFile(fileName) {

    var query = "?fileName=" + fileName + '.jpeg';
    console.log('delete files function');
    
    $.ajax({
        url: 'http://127.0.0.1:1986/TWAIN@Web/deleteTempFile' + query,
        method: 'GET',

        success: function (msg) {
            //toastMsg("success", msg, 1000);
            DownloadFiles = [];
        },
        error: function () {
            //toastMsg("error", 'فشلت عملية حذف الملف المؤقت', 1000);
        },
     
        complete: function () {
            
        }
    });
    //counterModify();
}

var GlobalScanSettingsName = "GlobalScanSettings";


var changeMode = function (enableID) {
    var switches = $('#form .mode-switch-container .mode-switch');
    for (var i = 0; i < switches.length; i++) {
        if ($(switches[i]).attr('id') == enableID) {
            $(switches[i]).removeClass('inactive').addClass('active');

            //if selected ADF
            var scanFeed = $("#form").find("#Form_ScanFeed");
            if (scanFeed.val() != 0 && scanFeed.is(':visible')) {
                $('#form .package-setting').addClass("disp-no");
                eval("$('#form .package-feeder-setting')." + $(switches[i]).attr('changeAction'));
            } else {
                eval("$('#form .package-setting')." + $(switches[i]).attr('changeAction'));
            }
        } else {
            $(switches[i]).removeClass('active').addClass('inactive');
        }
    }
};

$('#form .mode-switch').click(function () {
    if ($(this).is('.inactive')) {
        changeMode($(this).attr('id'));
    }
});
function pad(num, size) {
    var s = num + "";
    while (s.length < size) s = "0" + s;
    return s;
}

var counterModify = function () {
    var fileCounter = $("#Form_FileCounter").val();
    fileCounter = pad(fileCounter * 1 + 1, fileCounter.length);
    UpdateGlobalSetting(GetGlobalSettings(), { "FileName": $('#Form_FileName').val(), "CountScans": fileCounter });
    $("#Form_FileCounter").val(fileCounter);
};

var downloadFile = function (downloadFiles, save_as) {

    console.log('downloadFile function' + downloadFiles.length);
    //If more than one file you want to save as images - load them sequentially
    if ((save_as == undefined || save_as == 0) && downloadFiles.length > 1) {
        console.log(downloadFiles,"--------------3-----------")

        console.log("-----------------1-------------------")
        for (var i = 0; i < downloadFiles.length; i++) {
            downloadFile([downloadFiles[i]]);
        }
        console.log('save_as == undefined');
    } else {
        console.log("-----------------------2-----------------")
        //save_as = save_as == undefined ? "" : "saveAs=" + save_as;
        //var query = "?";
        //for (var i = 0; i < downloadFiles.length; i++) {
        //    query += 'fileId' + i + '=' + encodeURIComponent(downloadFiles[i].temp) + '&fileName' + i + '=' + encodeURIComponent(downloadFiles[i].file) + "&"
        //    + '&fileThumbName' + i + '=' + encodeURIComponent(downloadFiles[i].tempThumb) + "&";
        //}
        //query += save_as;
        //console.log('downloadFileFromFakeLinkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkk');
        //downloadFileFromFakeLink(encodeURI('http://127.0.0.1:1986/TWAIN@Web/download' + query));


        var query = "?";
        for (var i = 0; i < downloadFiles.length; i++) {
            var str = downloadFiles[i].temp
            str = str.substring(0, str.lastIndexOf("."));
            str = str + '.jpeg'
            query += 'fileId' + i + '=' + encodeURIComponent(downloadFiles[i].temp) + '&fileName' + i + '=' + encodeURIComponent(downloadFiles[i].file) + "&"
                + '&fileThumbName' + i + '=' + encodeURIComponent(str) + "&";
        }
        query += save_as;
        console.log('downloadFileFromFakeLink');
        downloadFileFromFakeLink(encodeURI('http://127.0.0.1:1986/TWAIN@Web/download' + query));

        counterModify();
    }
};



function downloadFileFromFakeLink(url) {
    console.log('download url');
    console.log(url);
    myfile.push(url);
    console.log("1-----")
    loadScan();

   // $("#scannedImage").attr('src', url);
}

function downloadFileFromFakeLink1(url) {
    var link = document.createElement('a');

    link.setAttribute('download', null);
    link.style.display = 'none';

    document.body.appendChild(link);

    link.setAttribute('href', url);
    link.click();

    document.body.removeChild(link);
}

var setSetting = function (setting, defaultSetting) {
    return (setting == undefined) ? defaultSetting : setting;
};
var ModeSwitch = function (modeSwitch) {
    var self = this;
    self.id = setSetting(modeSwitch.id, 'conventional-scan');
    self.countScans = setSetting(modeSwitch.countScans, '1');
    self.timeout = setSetting(modeSwitch.timeout, '5');
    self.saveAs = setSetting(modeSwitch.saveAs, '0');
};
var NameSetting = function (nameSetting) {
    var self = this;
    self.FileName = nameSetting.FileName;
    self.CountScans = nameSetting.CountScans;
};
var GlobalScanSettings = function (settings) {
    var self = this;
    self.NamesSettings = [];
    if (settings != undefined) {
        for (var key in settings) {
            self.NamesSettings.push(new NameSetting(settings[key]));
        }
    }
};

var ApplyGlobalSettings = function (globalSettings, fileName) {
    var key = SearchGlobalSetting(globalSettings, fileName);
    if (key != null) {
        $('#Form_FileCounter').val(globalSettings.NamesSettings[key].CountScans);
        return true;
    }
    return false;
};

var SearchGlobalSetting = function (globalSettings, fileName) {
    for (var key in globalSettings.NamesSettings) {
        if (globalSettings.NamesSettings[key].FileName == fileName) {
            return key;
        }
    }
    return null;
};

var UpdateGlobalSetting = function (globalSettings, nameSetting) {
    var key = SearchGlobalSetting(globalSettings, nameSetting.FileName);
    if (key == null)
        globalSettings.NamesSettings.push(new NameSetting(nameSetting));
    else
        globalSettings.NamesSettings[key].CountScans = nameSetting.CountScans;
    localStorage.setItem(GlobalScanSettingsName, JSON.stringify(globalSettings.NamesSettings));
};

var ScanSettings = function (settings) {
    var self = this;
    self.source = setSetting(settings.source, "0");
    self.fileName = setSetting(settings.fileName, "Scan");
    self.dpi = setSetting(settings.dpi, "150");
    self.scanFeed = setSetting(settings.scanFeed, null);
    self.pixelType = setSetting(settings.pixelType, "2");
    self.compressionFormat = setSetting(settings.compressionFormat, "100*Jpeg");
    self.format = setSetting(settings.format, "8,5*11,7");
    self.Counter = setSetting(settings.Counter, '001');
    self.modeSwitch = new ModeSwitch(setSetting(settings.modeSwitch, {}));
};

var canScan = false;
var localSettingsName = "ScanSettings";
var GetGlobalSettings = function () {
    var globalSettings = localStorage.getItem(GlobalScanSettingsName);
    return globalSettings != null ? new GlobalScanSettings(JSON.parse(globalSettings)) : new GlobalScanSettings();
};
var GetLocalSettings = function () {
    var localSettings = localStorage.getItem(localSettingsName);
    return localSettings != null ? new ScanSettings(JSON.parse(localSettings)) : new ScanSettings({});
};
var SetLocalSettings = function (source, fileName, dpi, scanFeed, pixelType, compressionFormat, format, counter, modeSwitch) {
    var settings = new ScanSettings({ "source": source, "fileName": fileName, "dpi": dpi, "scanFeed": scanFeed, "pixelType": pixelType, "compressionFormat": compressionFormat, "format": format, "modeSwitch": modeSwitch });
    localStorage.setItem(localSettingsName, JSON.stringify(settings));
    return settings;
};
var ApplyLocalSettings = function (settings, defaultScanSettings) {
    settings = new ScanSettings(settings);

    var dpiSelect = $('#form #Form_Dpi');
    var minDpi = dpiSelect.val(dpiSelect.find('option').first().val());;
    var maxDpi = dpiSelect.val(dpiSelect.find('option').last().val());;

    function isEmpty(str) {
        return (!str || 0 === str.length);
    }

    var selectedDpi;
    if (minDpi != undefined && !isEmpty(minDpi) && minDpi * 1 > settings.dpi * 1)
        selectedDpi = minDpi;
    else if (maxDpi != undefined && !isEmpty(maxDpi) && maxDpi * 1 < settings.dpi * 1)
        selectedDpi = maxDpi;
    else
        selectedDpi = settings.dpi;


    //$('#form').find('#Form_Dpi').val(selectedDpi);
    //$('#form').find('#Form_CompressionFormat').val(settings.compressionFormat);
    $('#form').find('#Form_FileName').val(settings.fileName);
    if (!ApplyGlobalSettings(GetGlobalSettings(), settings.fileName))
        $('#form').find('#Form_FileCounter').val(settings.Counter);
    //$('#form').find("#Form_ColorMode").val(settings.pixelType);
    //$('#form').find("#Form_ScanFeed").val(settings.scanFeed);
    //$('#form').find("#Form_Format option:contains(" + settings.format + ")").attr('selected', 'selected');
    $('#form').find('#Form_CountScans').val(settings.modeSwitch.countScans);
    $('#form').find('#Form_ScanInterval').val(settings.modeSwitch.timeout);
    $('#form').find('#Form_SaveAs').val(settings.modeSwitch.saveAs);
    changeMode(settings.modeSwitch.id);
};
var ActivateScanForm = function () {
    /*$('#form [type="submit"]').val("scan the!");*/
    $('#form select, #form input').removeAttr("disabled");
    canScan = true;
};
var DisactivateScanForm = function () {
    /*					$('#form [type="submit"]').val("scan progress!");*/
    $('#form select, #form input').attr("disabled", "disabled");

    canScan = false;
};

var DisactivateScanParameters = function () {
    //alert('DisactivateScanParameters');
    $('#form select:not(#Form_Source), #form input').attr("disabled", "disabled");

    canScan = false;
};

function showOverlay(msg) {
  
    $(".overlay-message").text(msg);
    $(".overlay, .overlay-message").show();
}

function hideOverlay() {
    $(".overlay-message").text("");
    $(".overlay, .overlay-message").hide();
}

var GetScanFormData = function () {
    var scanParameters = $('#form [name]');
    var values = "";
    for (var i = 0; i < scanParameters.length; i++) {
        values += $(scanParameters[i]).attr("name") + "=" + ($(scanParameters[i]).data('value') ? $(scanParameters[i]).data('value') : $(scanParameters[i]).val());
        values += i < (scanParameters.length - 1) ? "&" : "";
    }
    return values;
};
var sendAjax = function (method, doneFunction, data, async, failFunction, completeFunction, statusMsg, useOverlay) {
    if (method != undefined) {
        doneFunction = doneFunction == undefined ? function () {
        } : doneFunction;
        failFunction = failFunction == undefined ? function () {
        } : failFunction;
        completeFunction = completeFunction == undefined ? function () {
        } : completeFunction;
        data = data == undefined ? "" : "&" + data;
        if (useOverlay) {
            DisactivateScanForm();
        }
        $.ajax({
             //crossDomain: true,
             //  jsonp: false,
             //xhrFields: {
             //    withCredentials: true
             //},
          //  headers: { 'Access-Control-Allow-Origin': '*' },
            async: async,
            url: 'http://127.0.0.1:1986/TWAIN@Web/' + "ajax",
            type: 'POST',
            //dataType: 'jsonp',
            data: "method=" + method + data,
         
            success: function (responce) {
                ActivateScanForm();
                doneFunction(responce);
            },
            error: function (xhr, msdfsg) {
                var msg = xhr.responseText;
                if (msg == undefined || msg == "") {
                    msg = "حدث خطأ , الرجاء التأكد من تثبيت وتشغيل خدمة الماسح الضوئي علي جهازك";
                }
                failFunction(msg);
            },
         
            complete: function (resp) {
                completeFunction();
                if (useOverlay) {
                    // hideOverlay();
                    
                }
            }
        });
    }
};

var GetScanParameters = function (newSourceIndex) {
    var localSettings = GetLocalSettings();
    var fillSelect = function (element, list, selectedValue) {
        //alert('fill select');
        element.empty();
        for (var index in list) {
            var isSelected = selectedValue == list[index].key ? "selected=selected" : "";
            element.append("<option " + isSelected + " value='" + list[index].key + "'>" + list[index].value + "</option>");
        }
    };
    var clearSelect = function (element) {
        element.empty();
    };

    var sourceIndex = "sourceIndex=";
    if (newSourceIndex != undefined) {
        sourceIndex += newSourceIndex;
    } else {
        sourceIndex += localSettings.source;
    }
    var doneFunction = function (responce) {
        if (responce.sources != undefined && responce.sources.sourcesList != undefined && responce.sources.selectedSource != undefined && responce.sources.sourcesList.length > 0) {
            var form = $('#form');
            var selectSources = form.find("#Form_Source");
            var selectedSources = responce.sources.selectedSource;
            fillSelect(selectSources, responce.sources.sourcesList, selectedSources);
            //alert('after select filled');
            /*	var hintDPI = $('#form .DPI').find(".form-field-hint");
                if (responce.minResolution != undefined && responce.minResolution != undefined) {
                    hintDPI.find('.min').text(responce.minResolution);
                    hintDPI.find('.max').text(responce.maxResolution);
                    hintDPI.removeClass('disp-no');
                } else {
                    hintDPI.find('.min').text("");
                    hintDPI.find('.max').text("");
                    hintDPI.addClass('disp-no');
                }
*/
            //var selectTypePixel = $('#form').find("#Form_ColorMode");
            //if (responce.pixelTypes != undefined) {
            //    fillSelect(selectTypePixel, responce.pixelTypes);
            //} else {
            //    clearSelect(selectTypePixel);
            //}

            //var selectDpi = $('#form').find("#Form_Dpi");
            //if (responce.flatbedResolutions != undefined) {
            //    fillSelect(selectDpi, responce.flatbedResolutions);
            //} else {
            //    clearSelect(selectDpi);
            //}

            //var selectDpiHidden = $('#form').find("#Form_Dpi_Hidden");
            //if (responce.feederResolutions != undefined) {
            //    fillSelect(selectDpiHidden, responce.feederResolutions);
            //} else {
            //    clearSelect(selectDpiHidden);
            //}
            //selectDpiHidden.removeClass('flatbedResolutions');
            //selectDpiHidden.addClass('feederResolutions');

            //var selectScanFeed = $('#form').find("#Form_ScanFeed");
            //if (responce.scanFeeds != undefined) {
            //    fillSelect(selectScanFeed, responce.scanFeeds);
            //    selectScanFeed.parent().show();
            //} else {
            //    clearSelect(selectScanFeed);
            //    selectScanFeed.parent().hide();
            //}

            //var selectAllowedFormats = $('#form').find("#Form_Format");
            //if (responce.allowedFormats != undefined) {
            //    fillSelect(selectAllowedFormats, responce.allowedFormats);
            //} else {
            //    clearSelect(selectAllowedFormats);
            //}
            ApplyLocalSettings(localSettings);

            scanFeedOnChange();

            if (responce.allowedFormats == undefined || responce.pixelTypes == undefined || (responce.flatbedResolutions == undefined && responce.feederResolutions == undefined)) {
                DisactivateScanParameters();
                toastMsg("error", "لا يمكن الحصول علي خصائص الماسح الضوئي الرجاء التأكد  من أنه مشغل أو اختيار ماسح ضوئي أخر.", 1000);
            }
        } else {
            toastMsg("error", "لم يتم العثور علي أي ماسحات ضوئية الرجاء التأكد من الاتصال أو التحقق من تعريف الأجهزة", 1000);
        }
    };
    sendAjax("GetScannerParameters", doneFunction, sourceIndex, true, function (msg) {
        toastMsg("error", msg, 1000);
    }, null, "جاري تحميل اعدادات الماسح المختار ....", true);
};

$("#form").find("#Form_FileName").on('change', function () {
    if (!ApplyGlobalSettings(GetGlobalSettings(), $(this).val()))
        $("#form").find("#Form_FileCounter").val(new ScanSettings({}).Counter);
});

$("#form").find("#Form_Source").on('change', function () {
    GetScanParameters($(this).val());
});

var parseScanResponse = function (resp) {

    var downloadFiles = [];
    if (resp.file != undefined) {
        downloadFiles.push(new FileForDownload(resp));
    } else if (resp.files != undefined) {

        resp.files.forEach(function (file) {
            downloadFiles.push(new FileForDownload(file));

        });
    }
    return downloadFiles;
};

$("#form").submit(function () {
    // alert('submit1'); 
    showOverlay("Scanning...");
    console.log('submit');
    try {
        DisactivateScanForm();
        var save_as = $('#form #Form_SaveAs').val();
        var scanFeed = $('#form #Form_ScanFeed').val();
        SetLocalSettings($(this).find('#Form_Source').val(), $(this).find('#Form_FileName').val(), $(this).find('#Form_DPI').val(), $(this).find('#Form_ScanFeed').val(), $(this).find('#Form_ColorMode').val(), $(this).find('#Form_CompressionFormat').val(), $.trim($(this).find('#Form_Format option:selected').text()),
            $(this).find('#Form_FileCounter').val(),
            {
                "id": $('#form .mode-switch.active').attr('id'), "countScans": $(this).find('#Form_CountScans').val(), "timeout": $(this).find('#Form_ScanInterval').val(),
                "saveAs": save_as
            });
        //alert('pre scan');
        if ($('#form #package-scan').is('.active') && (scanFeed == undefined || scanFeed == 0)) {
            //    alert('pre scan2');
            var countScans = $('#form #Form_CountScans').val();
            var timeout = $('#form #Form_ScanInterval').val();

          

            if ((countScans * 1) != undefined && (timeout * 1) != undefined) {
                var i = 1;

                setTimeout(function scan() {
                    //alert('-------------start scan----------------');
                    sendAjax("Scan",
                        function (responce) {
                            console.log('-------------scan responce----------------');
                            console.log(responce);
                            console.log('---------------------------------------');
                            //alert('DownloadFiles.push1');
                            DownloadFiles.push(new FileForDownload(responce));
                            console.log('----------------DownloadFiles-----------------');
                            console.log(DownloadFiles);
                            if (save_as == '0' || i == countScans * 1) {
                                downloadFile(DownloadFiles, save_as);
                                //DownloadFiles = [];
                            }

                        },
                        GetScanFormData() + '&isPackage=true', true, function (msg) { toastMsg("error", msg, 1000); },
                        function () {
                            if (i < countScans) {
                                setTimeout(scan, (timeout * 1000));
                            }
                            else {
                                ActivateScanForm();
                                hideOverlay();
                            }
                            ++i;
                        });

                }, (timeout * 1000));
            }
        } else {
            // alert('pre scan3');
            if (!$('#form #package-scan').is('.active')) {
                save_as = null;
            }
            sendAjax("Scan", function (responce) {
                // alert('scan success');
                console.log('-------------scan responce2----------------');
                console.log(responce);
                console.log('---------------------------------------');
              
                toastMsg("success", 'تمت جلب الصورة من الماسح الضوئي', 1000);

                DownloadFiles = parseScanResponse(responce);
                downloadFile(DownloadFiles, save_as);
                hideOverlay();
            }, GetScanFormData(), true, function (msg) { toastMsg("success", msg, 1000); }, ActivateScanForm, "Scanning...", true);
        }
    }
    catch (ex) { console && console.log(ex); }

    return false;
});
$("#Form_FileName").focus();
//GetScanParameters();

function scanFeedOnChange() {

    function swapSelects(first, second) {

        var selectedValue = first.val();

        var firstOptions = first.html();
        var secondOptions = second.html();

        second.html(firstOptions);
        first.html(secondOptions);

        first.val(selectedValue);

    }

    function replaceSelectFromHidden(activeSelect, hiddenSelect, activeClass, hiddenClass) {
        if (hiddenSelect.hasClass(hiddenClass)) {

            swapSelects(activeSelect, hiddenSelect);

            hiddenSelect.removeClass(hiddenClass);
            hiddenSelect.addClass(activeClass);
        }

    }

    var selectDpi = $('#form').find("#Form_Dpi");
    var selectDpiHidden = $('#form').find("#Form_Dpi_Hidden");

    var scanFeed = $("#form").find("#Form_ScanFeed");
    if (scanFeed.val() != 0 && scanFeed.is(':visible')) {
        var scanMode = $("#form .mode-switch.active").attr('id');
        localStorage.setItem("previousScanMode", scanMode);
        changeMode("package-scan");
        $("#form").find("#conventional-scan").attr('disabled', 'disabled');

        replaceSelectFromHidden(selectDpi, selectDpiHidden, 'flatbedResolutions', 'feederResolutions');

    } else {
        $("#form").find("#conventional-scan").removeAttr('disabled');
        var previousScanMode = localStorage.getItem("previousScanMode");
        changeMode(previousScanMode);

        replaceSelectFromHidden(selectDpi, selectDpiHidden, 'feederResolutions', 'flatbedResolutions');

    }
};

$("#form").find("#Form_Source").on('change', function () {
    scanFeedOnChange();
});



$("#form").find("#Form_ScanFeed").on('change', scanFeedOnChange);
var FileForDownload = function (resp) {
  
    var self = this;
    self.temp = resp.temp;
    self.file = resp.file;
    self.tempThumb = resp.tempThumb;
};


scanFeedOnChange();
var refreshPage = function () {
    $.ajax({
        url: "",
        context: document.body,
        success: function (xhr) {
            alert("Application successfully restarted");
            location.reload();

        },
        error: function () {
            setTimeout(refreshPage, 500);
        }
    });
};

$("#restartLink").click(function () {
    $(".overlay-message").text("Restart Application...");
    $(".overlay, .overlay-message").show();
    sendAjax("Restart", function () { setTimeout(refreshPage, 2000); }, null, true, function () { setTimeout(refreshPage, 2000); }, null, "Restart Application...", false);
});

$("#restartWiaLink").click(function () {
    sendAjax("RestartWia", function () { alert("WIA service successfully restarted"); }, null, true, function () { alert("Unable to restart the WIA"); }, null, "Restarting Wia...", true);
});


$(function () {
    var trueAjax = (function () {
        var result = true;
        if (navigator.appName == 'Microsoft Internet Explorer') {
            var ua = navigator.userAgent;
            var re = new RegExp("MSIE ([0-9]{1,}[\.0-9]{0,})");
            if (re.exec(ua) != null) {
                rv = parseFloat(RegExp.$1);
                if (rv * 1 <= 9)
                    result = false;
            }
        }
        return result;
    })();

    //if (trueAjax) {
    //	$("#news").load("http://unit6.ru/twain-web?content=news&ver=1.6", function (a, b, c) {
    //		if (b != "error")
    //			$("#news").addClass("news");
    //	});
    //}
    //else {
    //	var xdr = new XDomainRequest();
    //	xdr.open("get", "http://unit6.ru/twain-web?content=news&ver=1.6");
    //	xdr.onload = function () {
    //		$("#news").html(xdr.responseText);
    //		$("#news").addClass("news");
    //	}
    //	xdr.send();
    //}
});


