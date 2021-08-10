function changeFont(element){
    element.setAttribute("style",element.getAttribute("style")+";font-family: Courier New");
    for(var i=0; i < element.children.length; i++){
        changeFont(element.children[i]);
    }
}
function openPage() {
    browser.tabs.create({
      url: "https://developer.mozilla.org"
    });
  }
  
  browser.browserAction.onClicked.addListener(openPage);