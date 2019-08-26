// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your Javascript code.
//IncreaseAttrib("KoordinationMotorikTot", "KoordinationMotorikUts")

function IncreaseAttrib(AttributeTotName, AttributeUtsName, ParentName) {
    let remainingPoints = document.getElementById("remainingPoints").value;
    remainingPoints--;

    if (remainingPoints >= 1) {

        let newRemainingPoints = document.createElement("INPUT");
        newRemainingPoints.setAttribute("type", "number");
        newRemainingPoints.setAttribute("value", remainingPoints);
        newRemainingPoints.setAttribute("id", "remainingPoints");
        newRemainingPoints.setAttribute("class", "form-control")
        let rPItemToBeRemoved = document.getElementById("remainingPoints");
        let rPparentItem = document.getElementById("CreationPoints");
        rPparentItem.replaceChild(newRemainingPoints, rPItemToBeRemoved);


        let TotValue = document.getElementById(AttributeTotName).value;
        TotValue++;
        let newTotAttribute = document.createElement("INPUT");
        newTotAttribute.setAttribute("type", "number");
        newTotAttribute.setAttribute("value", TotValue);
        newTotAttribute.setAttribute("id", AttributeTotName);
        newTotAttribute.setAttribute("class", "form-control")
        let totItemToBeRemoved = document.getElementById(AttributeTotName);
        let totParentItem = document.getElementById(ParentName);
        totParentItem.replaceChild(newTotAttribute, totItemToBeRemoved);

        let UtsValue = document.getElementById(AttributeUtsName).value;
        UtsValue++;
        let newUtsAttribute = document.createElement("INPUT");
        newUtsAttribute.setAttribute("type", "number");
        newUtsAttribute.setAttribute("value", UtsValue);
        newUtsAttribute.setAttribute("id", AttributeUtsName);
        newUtsAttribute.setAttribute("class", "form-control")
        let utsItemToBeRemoved = document.getElementById(AttributeUtsName);
        let utsParentItem = document.getElementById(ParentName);
        utsParentItem.replaceChild(newUtsAttribute, utsItemToBeRemoved);
    }
};

function DecreaseAttrib(AttributeTotName, AttributeUtsName, ParentName) {
    let remainingPoints = document.getElementById("remainingPoints").value;
    remainingPoints++;

    if (remainingPoints >= 1) {

        let newRemainingPoints = document.createElement("INPUT");
        newRemainingPoints.setAttribute("type", "number");
        newRemainingPoints.setAttribute("value", remainingPoints);
        newRemainingPoints.setAttribute("id", "remainingPoints");
        newRemainingPoints.setAttribute("class", "form-control")
        let rPItemToBeRemoved = document.getElementById("remainingPoints");
        let rPparentItem = document.getElementById("CreationPoints");
        rPparentItem.replaceChild(newRemainingPoints, rPItemToBeRemoved);


        let TotValue = document.getElementById(AttributeTotName).value;
        TotValue--;
        let newTotAttribute = document.createElement("INPUT");
        newTotAttribute.setAttribute("type", "number");
        newTotAttribute.setAttribute("value", TotValue);
        newTotAttribute.setAttribute("id", AttributeTotName);
        newTotAttribute.setAttribute("class", "form-control")
        let totItemToBeRemoved = document.getElementById(AttributeTotName);
        let totParentItem = document.getElementById(ParentName);
        totParentItem.replaceChild(newTotAttribute, totItemToBeRemoved);

        let UtsValue = document.getElementById(AttributeUtsName).value;
        UtsValue--;
        let newUtsAttribute = document.createElement("INPUT");
        newUtsAttribute.setAttribute("type", "number");
        newUtsAttribute.setAttribute("value", UtsValue);
        newUtsAttribute.setAttribute("id", AttributeUtsName);
        newUtsAttribute.setAttribute("class", "form-control")
        let utsItemToBeRemoved = document.getElementById(AttributeUtsName);
        let utsParentItem = document.getElementById(ParentName);
        utsParentItem.replaceChild(newUtsAttribute, utsItemToBeRemoved);
    }
};