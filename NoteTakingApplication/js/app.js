//Array of HTMLElements
const noteArray = [];

//Add a Note to the content area
function addNote(){
    document.getElementById("dragarea").insertAdjacentHTML("afterbegin", "<note-component></note-component>");
}

//Add a Title to your Note 
function addNoteTitle(){
    
    //Storing the Elements needed into variables
    var addTitleInput = document.getElementById("title-input");
    var addTitleButton = document.getElementById("add-title");
    
    //Creating the heading element and storing the input field text into it
    let obj = document.getElementById("title-input").value;
    
    //Removing the Input Field and Add Button 
    addTitleInput.remove();
    addTitleButton.remove();

    //Creating and Storing the Element that will be used 
    let addTitleParent = document.getElementById("cardContent");
    let titleParagraph = document.createElement("h4"); 
    titleParagraph.textContent += obj;

    //Insert the Element into the HTML Document
    addTitleParent.insertAdjacentHTML("afterbegin", "<h4 id=titleContent></h4>");
    document.getElementById("titleContent").append(titleParagraph);
}

function addNoteButton(){
    
    //ADDING THE BUTTONS FOR THE NOTES
    //Checking to see if an HTML Element Exists
    if(document.getElementById("sample-Note") != null){
        
        //Removing the Templated Sample Note Button
        var sampleNoteButton = document.getElementById("sample-Note");
        sampleNoteButton.remove();
    }

    if(document.getElementById("sample-Note") == null){
    
        //Adding the Created Note Button 
        var noteArea = document.getElementById("noteContainer");
        noteArea.insertAdjacentHTML("afterbegin", "<button type=\"button\" id=\"createdNoteButton\" class=\"btn btn-outline-secondary\"onclick=\"viewNote()\"></button>");
        var buttonText = document.getElementById("titleContent").innerHTML;
        document.getElementById("createdNoteButton").innerHTML += buttonText;

        //Resetting the Note Inputs
        var inputCard = document.getElementById("cardContent");
        var noteHeading = document.getElementById("titleContent");
        noteHeading.remove();
        inputCard.insertAdjacentHTML("afterbegin", "<div class=\"input-group id=\"add-title-area\" mb-3\"\><input type=\"text\" class=\"form-control\" id=\"title-input\"placeholder=\"Note Title:\" aria-label=\"Recipient's username\"aria-describedby=\"basic-addon2\"><div class=\"input-group-append\"><button class=\"btn btn-outline-secondary\" id=\"add-title\" type=\"button\" onclick=\"addNoteTitle()\">Add</button></div></div>");
    }
}

function createNoteForButton(){
    let obj = "dfgzfgzfgzxfgzf";
    
    //Displaying the span but not adding the created elements to it
    let mainNote = document.getElementById("cardContent"); 
    mainNote.insertAdjacentHTML("afterbegin", "<span id=cardBody>Programming</span>");
    
    var heading = document.createElement("h2");
    var timeCreated = document.createElement("p");
    var contentOfNote = document.createElement("p");

    heading.textContent += obj;
    noteContent.textContent += obj;
    timeCreated.textContent += obj;

    document.getElementById("cardBody").appendChild(heading);
    document.getElementById("cardBody").appendChild(contentOfNote);
    document.getElementById("cardBody").appendChild(timeCreated);    
    
    //let inputHeading = document.getElementById("titleContent").value;
    //let inputContent = document.getElementById("input-note").value;
    //let inputCreatedTime = document.getElementById("title-input").value;    
}

//onclick create the button for the note and dispay all of its contents 
function submitNote(){
    addNoteButton();
    createNoteForButton();
}

function viewNote(){
    
}

function deleteNoteContents(){

}

function confirmDeleteNoteContents(){

}

function editNoteContents(){

}

function editNote(){
    //Change Note Title
    //Delete entire Note
}

function addImage(){

}



       

          

        

        

        









