function includeFile (elementId, url) {
	if(document.getElementById(elementId) == null)
		return;
	
	var xhr= new XMLHttpRequest();
	xhr.open('GET', url, true);
	xhr.onreadystatechange= function() {
	    if (this.readyState!==4) return;
	    if (this.status!==200) return; // or whatever error handling you want
	    
	    document.getElementById(elementId).outerHTML= this.responseText;
	};
	xhr.send();
}
