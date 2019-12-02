// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your Javascript code.
//IncreaseAttrib("KoordinationMotorikTot", "KoordinationMotorikUts")

function IncreaseAttrib(AttributeTotName, AttributeUtsName, ParentName, PointsToAssign) {
    let remainingPoints = document.getElementById("remainingPoints").value;
    remainingPoints--;

    if (remainingPoints >= 0) {


        let newRemainingPoints = document.createElement("INPUT");
        newRemainingPoints.setAttribute("type", "number");
        newRemainingPoints.setAttribute("value", remainingPoints);
        newRemainingPoints.setAttribute("id", "remainingPoints");
        newRemainingPoints.setAttribute("class", "form-control");

        let rPItemToBeRemoved = document.getElementById("remainingPoints");
        let rPparentItem = document.getElementById("CreationPoints");
        rPparentItem.replaceChild(newRemainingPoints, rPItemToBeRemoved);


        let TotValue = document.getElementById(AttributeTotName).value;
        TotValue++;
        let newTotAttribute = document.createElement("INPUT");
        newTotAttribute.setAttribute("type", "text");
        newTotAttribute.setAttribute("value", TotValue);
        newTotAttribute.setAttribute("id", AttributeTotName);
        newTotAttribute.setAttribute("class", "form-control");
        newTotAttribute.setAttribute("name", 'PlayingCharacter.' + AttributeTotName);
        let totItemToBeRemoved = document.getElementById(AttributeTotName);
        let totParentItem = document.getElementById(ParentName);
        totParentItem.replaceChild(newTotAttribute, totItemToBeRemoved);

        let UtsValue = document.getElementById(AttributeUtsName).value;
        UtsValue++;
        let newUtsAttribute = document.createElement("INPUT");
        newUtsAttribute.setAttribute("type", "text");
        newUtsAttribute.setAttribute("value", UtsValue);
        newUtsAttribute.setAttribute("id", AttributeUtsName);
        newUtsAttribute.setAttribute("class", "form-control");
        newUtsAttribute.setAttribute("name", "PlayingCharacter." + AttributeUtsName);
        let utsItemToBeRemoved = document.getElementById(AttributeUtsName);
        let utsParentItem = document.getElementById(ParentName);
        utsParentItem.replaceChild(newUtsAttribute, utsItemToBeRemoved);

        let PTAValue = document.getElementById(PointsToAssign).value;
        PTAValue++;
        PTAValue++;
        ReplaceId(PTAValue, PointsToAssign);

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
        newRemainingPoints.setAttribute("class", "form-control");
        let rPItemToBeRemoved = document.getElementById("remainingPoints");
        let rPparentItem = document.getElementById("CreationPoints");
        rPparentItem.replaceChild(newRemainingPoints, rPItemToBeRemoved);


        let TotValue = document.getElementById(AttributeTotName).value;
        TotValue--;
        let newTotAttribute = document.createElement("INPUT");
        newTotAttribute.setAttribute("type", "number");
        newTotAttribute.setAttribute("value", TotValue);
        newTotAttribute.setAttribute("id", AttributeTotName);
        newTotAttribute.setAttribute("class", "form-control");
        newTotAttribute.setAttribute("name", 'PlayingCharacter.' + AttributeTotName);
        let totItemToBeRemoved = document.getElementById(AttributeTotName);
        let totParentItem = document.getElementById(ParentName);
        totParentItem.replaceChild(newTotAttribute, totItemToBeRemoved);

        let UtsValue = document.getElementById(AttributeUtsName).value;
        UtsValue--;
        let newUtsAttribute = document.createElement("INPUT");
        newUtsAttribute.setAttribute("type", "number");
        newUtsAttribute.setAttribute("value", UtsValue);
        newUtsAttribute.setAttribute("id", AttributeUtsName);
        newUtsAttribute.setAttribute("class", "form-control");
        newUtsAttribute.setAttribute("name", "PlayingCharacter." + AttributeUtsName);
        let utsItemToBeRemoved = document.getElementById(AttributeUtsName);
        let utsParentItem = document.getElementById(ParentName);
        utsParentItem.replaceChild(newUtsAttribute, utsItemToBeRemoved);

        let PTAValue = document.getElementById(PointsToAssign).value;
        PTAValue--;
        PTAValue--;
        ReplaceId(PTAValue, PointsToAssign)

    } else {
        alert("Du behöver minst 2 poäng i grundegenskapen.");
    }
};

function IncreaseSubAttribute(SubAttribute, PointsToAssign, TPName, ExpName, TTPName) {
    let SubAttributeValue = document.getElementById(SubAttribute).value;
    let PointsToAssignValue = document.getElementById(PointsToAssign).value;
    if (PointsToAssignValue > 0) {
        PointsToAssignValue--;
        SubAttributeValue++;

        ReplaceId(PointsToAssignValue, PointsToAssign);
        ReplaceId(SubAttributeValue, SubAttribute);



        let TP = document.getElementById(TPName).value;
        if (SubAttributeValue == 5) {
            TP = 1;
            ReplaceId(TP, TPName);
            ReplaceId(TP, TTPName);
        } else if (SubAttributeValue % 10 == 0) {
            let newTP = SubAttributeValue / 10;
            newTP++;
            ReplaceId(newTP, TPName);
            ReplaceId(newTP, TTPName);
        }
    } else {
        alert("Du har inga fler poäng att sätta ut!");
    }

};

function DecreaseSubAttribute(SubAttribute, PointsToAssign, TPName, ExpName, TTPName) {
    let SubAttributeValue = document.getElementById(SubAttribute).value;
    let PointsToAssignValue = document.getElementById(PointsToAssign).value;
    if (SubAttributeValue > 1) {
        PointsToAssignValue++;
        SubAttributeValue--;
        ReplaceId(PointsToAssignValue, PointsToAssign);
        ReplaceId(SubAttributeValue, SubAttribute);

        let TP = document.getElementById(TPName).value;
        if (SubAttributeValue == 4) {
            TP = 0;
            ReplaceId(TP, TPName);
            ReplaceId(TP, TTPName);
        } else if (SubAttributeValue % 10 == 9) {
            let newTP = SubAttributeValue / 10;
            newTP = newTP + 0.1;
            ReplaceId(newTP, TPName);
            ReplaceId(newTP, TTPName);
        }
    } else {
        alert("Du behöver ha minst 1 i din egenskap!");
    }
}

function ReplaceId(value, id) {
    let newSubAttribute = document.createElement("INPUT");
    newSubAttribute.setAttribute("type", "text");
    newSubAttribute.setAttribute("value", value);
    newSubAttribute.setAttribute("id", id);
    newSubAttribute.setAttribute("class", "form-control");
    newSubAttribute.setAttribute("name", "PlayingCharacter." + id);
    let SubAttributeToBeRemoved = document.getElementById(id);
    let SubAttributeParentId = "Parent" + document.getElementById(id).id;
    let SubAttributeParentItem = document.getElementById(SubAttributeParentId);
    SubAttributeParentItem.replaceChild(newSubAttribute, SubAttributeToBeRemoved);
};

function SelectPower(PowerId, PowerValue, CostLvl) {
    let remainingPoints = document.getElementById("remainingPoints").value;
    let PriorValue = document.getElementById(PowerId).value;
    if ((PowerValue - PriorValue) <= remainingPoints) {
        let newRemainingPointsValue = remainingPoints - (PowerValue - PriorValue);
        let newRemainingPoints = document.createElement("INPUT");
        newRemainingPoints.setAttribute("type", "number");
        newRemainingPoints.setAttribute("value", newRemainingPointsValue);
        newRemainingPoints.setAttribute("id", "remainingPoints");
        newRemainingPoints.setAttribute("class", "form-control");

        let rPItemToBeRemoved = document.getElementById("remainingPoints");
        let rPparentItem = document.getElementById("CreationPoints");
        rPparentItem.replaceChild(newRemainingPoints, rPItemToBeRemoved);

        let priorCostLvl = determineCostlvl(PriorValue);
        let newPriorValue = document.createElement("INPUT");
        newPriorValue.setAttribute("type", "Radio");
        newPriorValue.setAttribute("value", PriorValue);
        newPriorValue.setAttribute("name", PowerId);
        newPriorValue.setAttribute("class", priorCostLvl);
        newPriorValue.setAttribute("onclick", "SelectPower(" + PowerId + "," + PriorValue + ",'" + priorCostLvl + "')");

        let PriorItemToBeRemoved = document.getElementById(PowerId);
        let var1 = PowerId.toString();
        let var2 = PriorValue.toString();
        let ParentId = var1.concat(var2);
        let Parent = document.getElementById(ParentId);
        Parent.replaceChild(newPriorValue, PriorItemToBeRemoved);

        let newInputElement = document.createElement("INPUT");
        newInputElement.setAttribute("type", "Radio");
        newInputElement.setAttribute("value", PowerValue);
        newInputElement.setAttribute("name", PowerId);
        newInputElement.setAttribute("onclick", "SelectPower(" + PowerId + "," + PowerValue + ",'" + CostLvl + "') ");
        newInputElement.setAttribute("id", PowerId);
        newInputElement.setAttribute("class", CostLvl);
        newInputElement.setAttribute("checked", "checked");

        let PriorInputElement = document.getElementsByClassName(CostLvl);
        let var3 = PowerValue.toString();
        let ParentInputElementId = var1.concat(var3);
        let ParentInputElement = document.getElementById(ParentInputElementId);
        ParentInputElement.replaceChild(newInputElement, PriorInputElement.item(PowerId));

    } else {
        alert("Du har inte tillräkligt med poäng för att köpa denna nivå av kraften!");
        let priorCostLvl = determineCostlvl(PriorValue);
        let newPriorValue = document.createElement("INPUT");
        newPriorValue.setAttribute("type", "Radio");
        newPriorValue.setAttribute("value", PriorValue);
        newPriorValue.setAttribute("name", PowerId);
        newPriorValue.setAttribute("class", priorCostLvl);
        newPriorValue.setAttribute("onclick", "SelectPower(" + PowerId + "," + PriorValue + ",'" + priorCostLvl + "')");
        newPriorValue.setAttribute("checked", "checked");
        newPriorValue.setAttribute("id", PowerId);

        let PriorItemToBeRemoved = document.getElementById(PowerId);
        let var1 = PowerId.toString();
        let var2 = PriorValue.toString();
        let ParentId = var1.concat(var2);
        let Parent = document.getElementById(ParentId);
        Parent.replaceChild(newPriorValue, PriorItemToBeRemoved);
    }
    function determineCostlvl(PriorValue) {
        if (PriorValue == 0) { return "CostLvl1"; }
        if (PriorValue == 25) { return "CostLvl2"; }
        if (PriorValue == 50) { return "CostLvl3"; }
        if (PriorValue == 60) { return "CostLvl3"; }
        if (PriorValue == 100) { return "CostLvl4"; }
        if (PriorValue == 150) { return "CostLvl5"; }
        if (PriorValue == 175) { return "CostLvl5"; }
        if (PriorValue == 200) { return "CostLvl6"; }
        if (PriorValue == 250) { return "CostLvl7"; }
    }
}