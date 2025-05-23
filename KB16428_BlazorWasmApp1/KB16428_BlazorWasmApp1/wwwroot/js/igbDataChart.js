(() => {
    const OnFormatLabelLowScript = (args) => {
        return "L";
    }
    igRegisterScript("OnFormatLabelLowScript", OnFormatLabelLowScript, false);

    const OnFormatLabelMidiumScript = (args) => {
        return "M";
    }
    igRegisterScript("OnFormatLabelMidiumScript", OnFormatLabelMidiumScript, false);

    const OnFormatLabelHighScript = (args) => {
        return "H";
    }
    igRegisterScript("OnFormatLabelHighScript", OnFormatLabelHighScript, false);
})();