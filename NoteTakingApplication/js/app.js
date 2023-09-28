//Array of HTMLElements
const buttonArray = [];
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

function createNote(){
    
    //Gathering the text for the inputs
    let inputHeading = document.getElementById("titleContent").innerText;
    let inputContent = document.getElementById("input-note").value;
    let setDate = new Date().toDateString();
    let setTime = new Date().toLocaleTimeString();
    
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

    //Creating and inserting the span for the note
    let mainNote = document.getElementById("cardContent"); 
    mainNote.insertAdjacentHTML("afterbegin", "<span id=cardBody>Close note preview <i class=\"fa-solid fa-xmark\" onclick=\"removeNotePreview()\"\"></i></span>");

    //Creating the elements for the note
    var heading = document.createElement("h2");
    var contentOfNote = document.createElement("p");
    var timeCreated = document.createElement("p");

    //Appending the created elements to the span 
    document.getElementById("cardBody").append(heading);
    document.getElementById("cardBody").append(contentOfNote);
    document.getElementById("cardBody").append(timeCreated);

    //Adding the text to the contents
    heading.textContent += inputHeading;
    contentOfNote.textContent += inputContent;
    timeCreated.textContent += "Created on " + setDate + " " + setTime;  

    document.getElementById("input-note").value = "";
}

function saveNotePreviewContents(){    
    let notePreview = document.getElementById("cardBody").innerHTML;
    noteArray.push(notePreview);
}

//onclick create the button for the note and dispay all of its contents 
function submitNote(){
    createNote();
    saveNotePreviewContents();
}

//You should be able to remove the note preview
function removeNotePreview(){
    let notePreview = document.getElementById("cardBody");
    notePreview.remove();
}

function viewNote(){
    var note = noteArray[0];
    document.body.insertAdjacentHTML("afterend", "<span id=\"createdNoteSpan\"><\span>");
    document.getElementById("createdNoteSpan").innerHTML += note;
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



       

          

        

        

        









