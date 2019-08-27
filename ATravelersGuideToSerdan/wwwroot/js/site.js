// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your Javascript code.
//IncreaseAttrib("KoordinationMotorikTot", "KoordinationMotorikUts")

function IncreaseAttrib(AttributeTotName, AttributeUtsName, ParentName, PointsToAssign) {
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
        newTotAttribute.setAttribute("type", "text");
        newTotAttribute.setAttribute("value", TotValue);
        newTotAttribute.setAttribute("id", AttributeTotName);
        newTotAttribute.setAttribute("class", "form-control")
        let totItemToBeRemoved = document.getElementById(AttributeTotName);
        let totParentItem = document.getElementById(ParentName);
        totParentItem.replaceChild(newTotAttribute, totItemToBeRemoved);

        let UtsValue = document.getElementById(AttributeUtsName).value;
        UtsValue++;
        let newUtsAttribute = document.createElement("INPUT");
        newUtsAttribute.setAttribute("type", "text");
        newUtsAttribute.setAttribute("value", UtsValue);
        newUtsAttribute.setAttribute("id", AttributeUtsName);
        newUtsAttribute.setAttribute("class", "form-control")
        let utsItemToBeRemoved = document.getElementById(AttributeUtsName);
        let utsParentItem = document.getElementById(ParentName);
        utsParentItem.replaceChild(newUtsAttribute, utsItemToBeRemoved);

        let PTAValue = document.getElementById(PointsToAssign).value;
        PTAValue++;
        PTAValue++;
        let newPTAAttribute = document.createElement("INPUT");
        newPTAAttribute.setAttribute("type", "text");
        newPTAAttribute.setAttribute("value", PTAValue);
        newPTAAttribute.setAttribute("id", PointsToAssign);
        newPTAAttribute.setAttribute("class", "form-control");
        let PTAItemToBeRemoved = document.getElementById(PointsToAssign);
        let PTAParentId = "Parent" + document.getElementById(PointsToAssign).id;
        let PTAParentItem = document.getElementById(PTAParentId);
        PTAParentItem.replaceChild(newPTAAttribute, PTAItemToBeRemoved);
    } else {
        alert("Du har inga fler poäng att sätta ut");
    }
};

function DecreaseAttrib(AttributeTotName, AttributeUtsName, ParentName, PointsToAssign) {
    let TotValue = document.getElementById(AttributeTotName).value;

    if (TotValue > 2) {
        let remainingPoints = document.getElementById("remainingPoints").value;
        remainingPoints++;
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

        let PTAValue = document.getElementById(PointsToAssign).value;
        PTAValue--;
        PTAValue--;
        let newPTAAttribute = document.createElement("INPUT");
        newPTAAttribute.setAttribute("type", "text");
        newPTAAttribute.setAttribute("value", PTAValue);
        newPTAAttribute.setAttribute("id", PointsToAssign);
        newPTAAttribute.setAttribute("class", "form-control");
        let PTAItemToBeRemoved = document.getElementById(PointsToAssign);
        let PTAParentId = "Parent" + document.getElementById(PointsToAssign).id;
        let PTAParentItem = document.getElementById(PTAParentId);
        PTAParentItem.replaceChild(newPTAAttribute, PTAItemToBeRemoved);
    } else {
        alert("Du behöver minst 2 poäng i grundegenskapen.");
    }
};

function IncreaseSubAttribute(SubAttribute, PointsToAssign) {
    let SubAttributeValue = document.getElementById(SubAttribute).value;
    let PointsToAssignValue = document.getElementById(PointsToAssign).value;
    if (PointsToAssignValue > 0) {
        PointsToAssignValue--;
        SubAttributeValue++;

        let newPointsToAssign = document.createElement("INPUT");
        newPointsToAssign.setAttribute("type", "text");
        newPointsToAssign.setAttribute("value", PointsToAssignValue);
        newPointsToAssign.setAttribute("id", PointsToAssign);
        newPointsToAssign.setAttribute("class", "form-control");
        let PTAItemToBeRemoved = document.getElementById(PointsToAssign);
        let PTAParentId = "Parent" + document.getElementById(PointsToAssign).id;
        let PTAParentItem = document.getElementById(PTAParentId);
        PTAParentItem.replaceChild(newPointsToAssign, PTAItemToBeRemoved);

        let newSubAttribute = document.createElement("INPUT");
        newSubAttribute.setAttribute("type", "text");
        newSubAttribute.setAttribute("value", SubAttributeValue);
        newSubAttribute.setAttribute("id", SubAttribute);
        newSubAttribute.setAttribute("class", "form-control");
        let SubAttributeToBeRemoved = document.getElementById(SubAttribute);
        let SubAttributeParentId = "Parent" + document.getElementById(SubAttribute).id;
        let SubAttributeParentItem = document.getElementById(SubAttributeParentId);
        SubAttributeParentItem.replaceChild(newSubAttribute, SubAttributeToBeRemoved);
    } else {
        alert("Du har inga fler poäng att sätta ut!");
    }

};

function DecreaseSubAttribute(SubAttribute, PointsToAssign) {
    let SubAttributeValue = document.getElementById(SubAttribute).value;
    let PointsToAssignValue = document.getElementById(PointsToAssign).value;
    if (SubAttributeValue > 1) {
        PointsToAssignValue++;
        SubAttributeValue--;

        let newPointsToAssign = document.createElement("INPUT");
        newPointsToAssign.setAttribute("type", "text");
        newPointsToAssign.setAttribute("value", PointsToAssignValue);
        newPointsToAssign.setAttribute("id", PointsToAssign);
        newPointsToAssign.setAttribute("class", "form-control");
        let PTAItemToBeRemoved = document.getElementById(PointsToAssign);
        let PTAParentId = "Parent" + document.getElementById(PointsToAssign).id;
        let PTAParentItem = document.getElementById(PTAParentId);
        PTAParentItem.replaceChild(newPointsToAssign, PTAItemToBeRemoved);

        let newSubAttribute = document.createElement("INPUT");
        newSubAttribute.setAttribute("type", "text");
        newSubAttribute.setAttribute("value", SubAttributeValue);
        newSubAttribute.setAttribute("id", SubAttribute);
        newSubAttribute.setAttribute("class", "form-control");
        let SubAttributeToBeRemoved = document.getElementById(SubAttribute);
        let SubAttributeParentId = "Parent" + document.getElementById(SubAttribute).id;
        let SubAttributeParentItem = document.getElementById(SubAttributeParentId);
        SubAttributeParentItem.replaceChild(newSubAttribute, SubAttributeToBeRemoved);
    } else {
        alert("Du behöver ha minst 1 i din egenskap!");
    }
};