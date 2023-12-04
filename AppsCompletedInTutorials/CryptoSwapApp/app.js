function showMenu () {
    let button = document.querySelector(".dropdownmenu");
    button.classList.toggle("active");
}

var networkbutton = document.querySelector(".networkbutton");
networkbutton.addEventListener("mouseover", displayDiv(), false);

function displayDiv () {
    let selectnetworkmenu = document.querySelector(".selectnetworkmenu");
    selectnetworkmenu.setAttribute("style", "display: block;");
}

function displayWalletConnector() {
    let button = document.querySelector(".walletconnector");
    button.classList.toggle("active");
}

function closeWalletConnector() {
    let button = document.querySelector(".walletconnector");
    button.classList.remove("active")
}


function connectMetaMask(){
    //Check to see if extension is installed
    
    //if not installed redirect the user to the metamask website to install
  };
  
//chain id 31337

//Connecting to the MetaMask Wallet
//The first thing we need to do in our Dapp is to connect to our MetaMask Wallet.

//1We need to create a function to see if the MetaMask Chrome extension is installed
//2If MetaMask is not installed we:
//-Change our connectButton to Click here to install MetaMask
//-When clicking that button it should take us to a page that will allow us to install the extension
//-Disable the button
//3If MetaMask is installed we:
//-Change our connectButton to Connect
//-When clicking that button it should allow us to connect to our MetaMask wallet
//-Disable the button