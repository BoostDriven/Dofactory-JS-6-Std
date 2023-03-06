var Dofactory = {
    namespace: function (name) {
        var parts = name.split(".");
        var ns = this;

        for (var i = 0, len = parts.length; i < len; i++) {
            ns[parts[i]] = ns[parts[i]] || {};
            ns = ns[parts[i]];
        }

        return ns;
    }
};

function openPdf(name, root) {
    var target = "target";
    switch (name) {
        case "GettingStarted": name = "1. Getting Started"; target += "1"; break;
        case "PatternEssentials": name = "2. Pattern Essentials"; target += "2"; break;
        case "ModernPatterns": name = "3. Modern Patterns"; target += "3"; break;
        case "ClassicPatterns": name = "4. Classic Patterns"; target += "4"; break;
        case "ModelViewPatterns": name = "5. Model View Patterns"; target += "5"; break;
        case "jQueryPatterns": name = "6. jQuery Patterns"; target += "6"; break;
        case "ArchitecturePatterns": name = "7. Architecture Patterns"; target += "7"; break;
        case "PatternsInAction": name = "8. Patterns In Action"; target += "8"; break;
        case "Rockstar": name = "9. JavaScript Rockstar"; target += "9"; break;
    }
    var pdf = "/pdf/" + name + ".pdf";
    window.open(pdf, target, "menubar=1,location=1,resizable=1,toolbar=1" ).focus(); 
    return false;
}

function openSite(url) {
    window.open(url, "url", "scrollbars=yes,resizable=yes").focus();
    return false;
}

$(function () {
    prettyPrint();

    // animates page to scroll to top
    $('#totop').on('click', function () {
        $("html, body").animate({ scrollTop: 0 }, 500);
        return false;
    });
});
