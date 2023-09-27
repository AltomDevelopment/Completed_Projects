//By extending the generic HTMLElement class, you can create any kind of element you want. 
//It's also possible to extend specific elements like HTMLParagraphElement.

  class Note extends HTMLElement {
    constructor() {
      super();
   }
  
   connectedCallback() 
   {
      this.innerHTML = `
      <body>
      <div class="fixed-action-btn" id="main-note">
      <a class="btn-floating btn-large red">
          <i class="large material-icons" onclick="editNote()">mode_edit</i>
      </a>
      <div class="card" id="cardContent">
      <div class="card-content" id="cardContent">
          <div class="input-group id="add-title-area" mb-3">
              <input type="text" class="form-control" id="title-input" 
              placeholder="Note Title:" aria-label="Recipient's username"
                  aria-describedby="basic-addon2">
              <div class="input-group-append">
                  <button class="btn btn-outline-secondary" id="add-title" 
                  type="button" onclick="addNoteTitle()">Add</button>
              </div>
          </div>
          <textarea class="note-input" id="input-note" contenteditable="true" 
          placeholder="enter your note..."></textarea>
      </div>
      <span class="button-row">
          <button class="btn waves-effect waves-light submit-button" 
          type="submit" name="action" onclick="submitNote()">Submit
          </button>
      </span>
      <div id="noteContainer">
        <button type="button" class="btn btn-outline-secondary" id="sample-Note" 
        onclick="viewNote()">Sample Note</button>
      </div>
      <span class="button-row">
          <button class="btn waves-effect waves-light delete-button" type="default" 
          name="action" onclick="confirmDeleteNoteContents()">Delete Note
          </button>
          <button class="btn waves-effect waves-light edit-button" type="default" 
          name="action" onclick="editNoteContents()">Edit Note
          </button>
      </span>
      </div>
      </body>`;
    }
}
customElements.define('note-component', Note);
