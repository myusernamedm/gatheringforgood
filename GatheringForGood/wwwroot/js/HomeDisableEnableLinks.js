function DisableLinks(elem, disable, page) {
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
}