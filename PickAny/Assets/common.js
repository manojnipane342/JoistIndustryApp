$(document).ready(function () {
    $("#overlay").hide();
});

function bytesToSize(bytes) {
    if (bytes == 0) return '0 KB';
    var iSize = (bytes / 1024);
    return parseInt(Math.round(iSize * 100) / 100);
};
function isEmail(email) {
    var regex = /^([a-zA-Z0-9_.+-])+\@(([a-zA-Z0-9-])+\.)+([a-zA-Z0-9]{2,4})+$/;
    return regex.test(email);
}
function PasswordChecker(password) {
    if (password != "") {
        if (password.length < 8)
            return "Password must contain at least eight characters.";

        re = /[A-Z]/;
        if (!re.test(password))
            return "Password must contain at least one uppercase letter.";

        re = /[!@#$%\^&*(){}[\]<>?/|\-]/;
        if (!re.test(password))
            return "Password must contain at least one special character.";
    }
    else {
        return "Password is required field.";
    }
    return "success";
}
function ajaxFunc(url, data, callback, options){
    let defaults = {
        type: "POST",
        url: url,
        data: data,
        dataType: 'json',
        beforeSend: x => {
            StartProcess();
}
};
if(data instanceof FormData){
    defaults.contentType = false;
    defaults.processData= false;
}
if(options){
    defaults = $.extend({}, defaults, options);
}
return $.ajax(defaults)
    .done(data => {
        if(data.status == "Fail"){
            $("#lblError").addClass("error").text(data.error).show();
} else {
    if(typeof callback === "function"){
        callback(data.data);
    }
}
})
        .always(x => {
            StopProcess();
});
}

function getFormData(obj) {
    let convertToFormData = function(prefix, obj, formData) {
        prefix = prefix || "";
        if(Array.isArray(obj)){
            obj.forEach((x,i) => {
                convertToFormData(prefix + "[" + i + "]", x, formData);
        });
    } else if(typeof obj === "object") {
        for(let p in obj){
            let _prefix = prefix == "" ? p : prefix + "[" + p + "]";
            if(Array.isArray(obj[p])) {
                obj[p].forEach((x,i) => {
                    convertToFormData(_prefix + "[" + i + "]", x, formData);
            });
        } else if(typeof obj[p] === "object") {
            convertToFormData(_prefix, obj[p], formData);
        } else {
                formData.append(_prefix, obj[p]);
    }
}
} else {
    formData.append(prefix, obj);
}
}
var formData = new FormData();
convertToFormData("", obj, formData);
return formData;
}
