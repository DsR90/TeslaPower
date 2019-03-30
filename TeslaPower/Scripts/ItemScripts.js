var item = 2;
function addItems() {   
    var parent = document.getElementById("items");
    var divE = document.createElement("div");
    var divA = document.createAttribute("id");
    divA.value = "item" + item;
    divE.setAttribute(divA);
    parent.appendChild(divE);
    var kva = addKvaTxtBox();
    divE.appendChild(kva);
}
function addKvaTxtBox() {
    var parent = document.getElementById("item"+item);
    var kva = document.createElement("input");
    var kvaTypeA = document.createAttribute("type");
    kvaTypeA.value = "text";
    var kvaTypeID = document.createAttribute("id");
    kvaTypeA.value = "txtKva" + item;
    kva.setAttribute(kvaTypeA);
    kva.setAttribute(kvaTypeID);
    parent.appendChild(kva);
}