function DisableEnableLinks(elem, disable, page) {
    document.getElementById(elem).onclick
        = function () {
            objLinks = document.links;
            for (i = 0; i < objLinks.length; i++) {
                objLinks[i].disabled = disable;
                //link with onclick
                if (objLinks[i].onclick && disable) {
                    objLinks[i].onclick =
                        new Function("return false;" + objLinks[i].onclick.toString().getFuncBody());
                }
                //link without onclick
                else if (disable) {
                    objLinks[i].onclick = function () { return false; }
                }
                //remove return false with link without onclick
                else if
                    (!disable && objLinks[i].onclick.toString().indexOf("function(){return false;}") != -1) {
                    objLinks[i].onclick = null;
                }
                //remove return false link with onclick
                else if (!disable && objLinks[i].onclick.toString().indexOf("return false;") != -1) {
                    strClick = objLinks[i].onclick.toString().getFuncBody().replace("return false;", "")
                    objLinks[i].onclick = new Function(strClick);
                }
            }
        }

    if (page == "RGW") {
        var checkBoxStatus = document.getElementById("RGWEnableSharingCheckbox");
        sessionStorage.setItem("page", "RGW");
    } else if (page == "RDF") {
        var checkBoxStatus = document.getElementById("RDFEnableSharingCheckbox");
        sessionStorage.setItem("page", "RDF");
    } else if (page == "RAE") {
        var checkBoxStatus = document.getElementById("RAEEnableSharingCheckbox");
        sessionStorage.setItem("page", "RAE");
    }

    if (checkBoxStatus.checked) {
        sessionStorage.setItem("checkBoxStatus", "true");
    } else {
        sessionStorage.setItem("checkBoxStatus", "false");
    }

    switch (elem)
    {
        case "MouseClickIconRow1":
            sessionStorage.setItem("identifyIcon", "ReduceMeat");
            break;
        case "HandTapIconRow1":
            sessionStorage.setItem("identifyIcon", "ReduceMeat");
            break;
        case "rdfMouseClickIconRow1":
            sessionStorage.setItem("identifyIcon", "ReduceMeat");
            break;
        case "rdfHandTapIconRow1":
            sessionStorage.setItem("identifyIcon", "ReduceMeat");
            break;
        case "raeMouseClickIconRow1":
            sessionStorage.setItem("identifyIcon", "ReduceMeat");
            break;
        case "raeHandTapIconRow1":
            sessionStorage.setItem("identifyIcon", "ReduceMeat");
            break;
        case "MouseClickIconRow2":
            sessionStorage.setItem("identifyIcon", "PlantTree");
            break;
        case "HandTapIconRow2":
            sessionStorage.setItem("identifyIcon", "PlantTree");
            break;
        case "rdfMouseClickIconRow2":
            sessionStorage.setItem("identifyIcon", "GoVegtarian");
            break;
        case "rdfHandTapIconRow2":
            sessionStorage.setItem("identifyIcon", "GoVegtarian");
            break;
        case "raeMouseClickIconRow2":
            sessionStorage.setItem("identifyIcon", "FamilySizes");
            break;
        case "raeHandTapIconRow2":
            sessionStorage.setItem("identifyIcon", "FamilySizes");
            break;
        case "MouseClickIconRow3":
            sessionStorage.setItem("identifyIcon", "EatOrganic");
            break;
        case "HandTapIconRow3":
            sessionStorage.setItem("identifyIcon", "EatOrganic");
            break;
        case "rdfMouseClickIconRow3":
            sessionStorage.setItem("identifyIcon", "GoVegan");
            break;
        case "rdfHandTapIconRow3":
            sessionStorage.setItem("identifyIcon", "GoVegan");
            break;
        case "raeMouseClickIconRow3":
            sessionStorage.setItem("identifyIcon", "MinimisePlastic");
            break;
        case "raeHandTapIconRow3":
            sessionStorage.setItem("identifyIcon", "MinimisePlastic");
            break;
        case "MouseClickIconRow4":
            sessionStorage.setItem("identifyIcon", "GoVegtarian");
            break;
        case "HandTapIconRow4":
            sessionStorage.setItem("identifyIcon", "GoVegtarian");
            break;
        case "rdfMouseClickIconRow4":
            sessionStorage.setItem("identifyIcon", "EatOrganic");
            break;
        case "rdfHandTapIconRow4":
            sessionStorage.setItem("identifyIcon", "EatOrganic");
            break;
        case "raeMouseClickIconRow4":
            sessionStorage.setItem("identifyIcon", "GoVegtarian");
            break;
        case "raeHandTapIconRow4":
            sessionStorage.setItem("identifyIcon", "GoVegtarian");
            break;
        case "MouseClickIconRow5":
            sessionStorage.setItem("identifyIcon", "GoVegan");
            break;
        case "HandTapIconRow5":
            sessionStorage.setItem("identifyIcon", "GoVegan");
            break;
        case "rdfMouseClickIconRow5":
            sessionStorage.setItem("identifyIcon", "HabitatRestoration");
            break;
        case "rdfHandTapIconRow5":
            sessionStorage.setItem("identifyIcon", "HabitatRestoration");
            break;
        case "raeMouseClickIconRow5":
            sessionStorage.setItem("identifyIcon", "GoVegan");
            break;
        case "raeHandTapIconRow5":
            sessionStorage.setItem("identifyIcon", "GoVegan");
            break;
        case "MouseClickIconRow6":
            sessionStorage.setItem("identifyIcon", "LiveCarFree");
            break;
        case "HandTapIconRow6":
            sessionStorage.setItem("identifyIcon", "LiveCarFree");
            break;
        case "rdfMouseClickIconRow6":
            sessionStorage.setItem("identifyIcon", "ZeroDeforestation");
            break;
        case "rdfHandTapIconRow6":
            sessionStorage.setItem("identifyIcon", "ZeroDeforestation");
            break;
        case "raeMouseClickIconRow6":
            sessionStorage.setItem("identifyIcon", "HabitatRestoration");
            break;
        case "raeHandTapIconRow6":
            sessionStorage.setItem("identifyIcon", "HabitatRestoration");
            break;
        case "MouseClickIconRow7":
            sessionStorage.setItem("identifyIcon", "GreenRecovery");
            break;
        case "HandTapIconRow7":
            sessionStorage.setItem("identifyIcon", "GreenRecovery");
            break;
        case "rdfMouseClickIconRow7":
            sessionStorage.setItem("identifyIcon", "Paperless");
            break;
        case "rdfHandTapIconRow7":
            sessionStorage.setItem("identifyIcon", "Paperless");
            break;
        case "raeMouseClickIconRow7":
            sessionStorage.setItem("identifyIcon", "WildlifeRefuge");
            break;
        case "raeHandTapIconRow7":
            sessionStorage.setItem("identifyIcon", "WildlifeRefuge");
            break;
        case "MouseClickIconRow8":
            sessionStorage.setItem("identifyIcon", "MinimisePlastic");
            break;
        case "HandTapIconRow8":
            sessionStorage.setItem("identifyIcon", "MinimisePlastic");
            break;
        case "rdfMouseClickIconRow8":
            sessionStorage.setItem("identifyIcon", "DonateForestryTrust");
            break;
        case "rdfHandTapIconRow8":
            sessionStorage.setItem("identifyIcon", "DonateForestryTrust");
            break;
        case "raeMouseClickIconRow8":
            sessionStorage.setItem("identifyIcon", "StandUp");
            break;
        case "raeHandTapIconRow8":
            sessionStorage.setItem("identifyIcon", "StandUp");
            break;
        case "MouseClickIconRow9":
            sessionStorage.setItem("identifyIcon", "BuyLocal");
            break;
        case "HandTapIconRow9":
            sessionStorage.setItem("identifyIcon", "BuyLocal");
            break;
        case "rdfMouseClickIconRow9":
            sessionStorage.setItem("identifyIcon", "PlantTree");
            break;
        case "rdfHandTapIconRow9":
            sessionStorage.setItem("identifyIcon", "PlantTree");
            break;
        case "raeMouseClickIconRow9":
            sessionStorage.setItem("identifyIcon", "HerbsAndPests");
            break;
        case "raeHandTapIconRow9":
            sessionStorage.setItem("identifyIcon", "HerbsAndPests");
            break;
        case "MouseClickIconRow10":
            sessionStorage.setItem("identifyIcon", "Cycle");
            break;
        case "HandTapIconRow10":
            sessionStorage.setItem("identifyIcon", "Cycle");
            break;
        case "rdfMouseClickIconRow10":
            sessionStorage.setItem("identifyIcon", "BuyRecycled");
            break;
        case "rdfHandTapIconRow10":
            sessionStorage.setItem("identifyIcon", "BuyRecycled");
            break;
        case "raeMouseClickIconRow10":
            sessionStorage.setItem("identifyIcon", "SlowDown");
            break;
        case "raeHandTapIconRow10":
            sessionStorage.setItem("identifyIcon", "SlowDown");
            break;
        case "MouseClickIconRow11":
            sessionStorage.setItem("identifyIcon", "DriveElectric");
            break;
        case "HandTapIconRow11":
            sessionStorage.setItem("identifyIcon", "DriveElectric");
            break;
        case "rdfMouseClickIconRow11":
            sessionStorage.setItem("identifyIcon", "StandUp");
            break;
        case "rdfHandTapIconRow11":
            sessionStorage.setItem("identifyIcon", "StandUp");
            break;
        case "raeMouseClickIconRow11":
            sessionStorage.setItem("identifyIcon", "PlantNative");
            break;
        case "raeHandTapIconRow11":
            sessionStorage.setItem("identifyIcon", "PlantNative");
            break;
        case "MouseClickIconRow12":
            sessionStorage.setItem("identifyIcon", "GrowYourOwn");
            break;
        case "HandTapIconRow12":
            sessionStorage.setItem("identifyIcon", "GrowYourOwn");
            break;
        case "rdfMouseClickIconRow12":
            sessionStorage.setItem("identifyIcon", "SignPetition");
            break;
        case "rdfHandTapIconRow12":
            sessionStorage.setItem("identifyIcon", "SignPetition");
            break;
        case "raeMouseClickIconRow12":
            sessionStorage.setItem("identifyIcon", "GreenRecovery");
            break;
        case "raeHandTapIconRow12":
            sessionStorage.setItem("identifyIcon", "GreenRecovery");
            break;
        case "MouseClickIconRow13":
            sessionStorage.setItem("identifyIcon", "RenewableEnergy");
            break;
        case "HandTapIconRow13":
            sessionStorage.setItem("identifyIcon", "RenewableEnergy");
            break;
        case "rdfMouseClickIconRow13":
            sessionStorage.setItem("identifyIcon", "FollowSocial");
            break;
        case "rdfHandTapIconRow13":
            sessionStorage.setItem("identifyIcon", "FollowSocial");
            break;
        case "raeMouseClickIconRow13":
            sessionStorage.setItem("identifyIcon", "BuyRecycled");
            break;
        case "raeHandTapIconRow13":
            sessionStorage.setItem("identifyIcon", "BuyRecycled");
            break;
        case "MouseClickIconRow14":
            sessionStorage.setItem("identifyIcon", "PublicTransport");
            break;
        case "HandTapIconRow14":
            sessionStorage.setItem("identifyIcon", "PublicTransport");
            break;
        case "raeMouseClickIconRow14":
            sessionStorage.setItem("identifyIcon", "RecyclingBin");
            break;
        case "raeHandTapIconRow14":
            sessionStorage.setItem("identifyIcon", "RecyclingBin");
            break;
        case "MouseClickIconRow15":
            sessionStorage.setItem("identifyIcon", "Carpool");
            break;
        case "HandTapIconRow15":
            sessionStorage.setItem("identifyIcon", "Carpool");
            break;
        case "raeMouseClickIconRow15":
            sessionStorage.setItem("identifyIcon", "SignPetition");
            break;
        case "raeHandTapIconRow15":
            sessionStorage.setItem("identifyIcon", "SignPetition");
            break;
        case "MouseClickIconRow16":
            sessionStorage.setItem("identifyIcon", "FlyLess");
            break;
        case "HandTapIconRow16":
            sessionStorage.setItem("identifyIcon", "FlyLess");
            break;
        case "MouseClickIconRow17":
            sessionStorage.setItem("identifyIcon", "StandUp");
            break;
        case "HandTapIconRow17":
            sessionStorage.setItem("identifyIcon", "StandUp");
            break;
        case "MouseClickIconRow18":
            sessionStorage.setItem("identifyIcon", "RecyclingBin");
            break;
        case "HandTapIconRow18":
            sessionStorage.setItem("identifyIcon", "RecyclingBin");
            break;
        case "MouseClickIconRow19":
            sessionStorage.setItem("identifyIcon", "CompostBin");
            break;
        case "HandTapIconRow19":
            sessionStorage.setItem("identifyIcon", "CompostBin");
            break;
        case "MouseClickIconRow20":
            sessionStorage.setItem("identifyIcon", "HomeInsulation");
            break;
        case "HandTapIconRow20":
            sessionStorage.setItem("identifyIcon", "HomeInsulation");
            break;
        case "MouseClickIconRow21":
            sessionStorage.setItem("identifyIcon", "ShorterShowers");
            break;
        case "HandTapIconRow21":
            sessionStorage.setItem("identifyIcon", "ShorterShowers");
            break;
        case "MouseClickIconRow22":
            sessionStorage.setItem("identifyIcon", "FluorescentBulbs");
            break;
        case "HandTapIconRow22":
            sessionStorage.setItem("identifyIcon", "FluorescentBulbs");
            break;
        case "MouseClickIconRow23":
            sessionStorage.setItem("identifyIcon", "TurnOffLights");
            break;
        case "HandTapIconRow23":
            sessionStorage.setItem("identifyIcon", "TurnOffLights");
            break;
        case "MouseClickIconRow24":
            sessionStorage.setItem("identifyIcon", "SignPetition");
            break;
        case "HandTapIconRow24":
            sessionStorage.setItem("identifyIcon", "SignPetition");
            break;
        default:
            break;
    }
    sessionStorage.setItem("showSocial", "true");
}
String.prototype.getFuncBody = function () {
    var str = this.toString();
    str = str.replace(/[^{]+{/, "");
    str = str.substring(0, str.length - 1);
    str = str.replace(/\n/gi, "");
    if (!str.match(/\(.*\)/gi)) str += ")";
    return str;
}