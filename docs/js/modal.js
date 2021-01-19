// Ref: https://www.w3schools.com/howto/howto_css_modal_images.asp

var imgs = null;
var imgsCount =0;

function addImgClickEvents() {
	imgs = document.getElementsByTagName("img");
	
	for (var i = 0; i < imgs.length; i++) {
		if(imgs[i].id != "_modalImg_" && !imgs[i].classList.contains("None")) {
			showModal(imgs[i]);
			imgs[i].modal = i + 1;
			imgsCount = i + 1;
		}
  }
}

function changeImage(incrementCount) {
	
	currentImgIdx = getCurrentImageIndex();
	
	// Unknown error
	if(currentImgIdx < 0) {
		return;
	}
	
	var nextImgIdx = currentImgIdx + incrementCount;
	
	if(nextImgIdx < 0) {
		return;
	}
	if(nextImgIdx >= imgs.length) {
		return;
	}
	
	if(imgs[nextImgIdx].id == "_modalImg_") {
		changeImage(incrementCount * 2);
		return;
	}
	
	if(!imgs[nextImgIdx].hasOwnProperty("modal")) {
		return;
	}
	
	imgs[nextImgIdx].click();
}

function closeModal() {
	var modal = document.getElementById("_modal_");
		
	if(modal==null) {
		return;
	}
	
	modal.style.display = "none";
}

function getCurrentImageIndex() {
	var modalImg = document.getElementById("_modalImg_");
	
	for (var i = 0; i < imgs.length; i++) {
		if(imgs[i].src == modalImg.src) {
			return i;
		}
	}
	
	return -1;
}

function modalClick(e) {
	var modalImg = document.getElementById("_modalImg_");
	
	var imgPosX = modalImg.offsetLeft;
	var imgPosY = modalImg.offsetTop;
	var imgHeight = modalImg.height;
	var imgWidth = modalImg.width;
	var PosX = 0;
  var PosY = 0;
	
	if (!e) var e = window.event;
	
	if (e.pageX || e.pageY)
  {
    PosX = e.pageX;
    PosY = e.pageY;
  }
  else if (e.clientX || e.clientY)
  {
    PosX = e.clientX + document.body.scrollLeft + document.documentElement.scrollLeft;
    PosY = e.clientY + document.body.scrollTop + document.documentElement.scrollTop;
  }
  
  PosX = PosX - imgPosX;
  PosY = PosY - imgPosY;
	
	if(PosX < imgWidth/2) {
		changeImage(-1);
	}
	else {
		changeImage(1);
	}
}

function showModal(imgElement)
{
	imgElement.onclick = function(){
		// Get the modal
		var modal = document.getElementById("_modal_");
		
		if(modal==null) {
			return;
		}
	
		// Get the image and insert it inside the modal - use its "alt" text as a caption
		var modalImg = document.getElementById("_modalImg_");
		var captionText = document.getElementById("_modalCaption_");
		
		if(modalImg==null || captionText==null)
			return;
		
	  modal.style.display = "block";
	  modalImg.src = this.src;
	  modalImg.alt = this.alt;
	  captionText.innerHTML = this.alt + "<br /><i>" + this.modal + " of " + imgsCount + " images</i>";
	}
	imgElement.title = imgElement.alt;
}