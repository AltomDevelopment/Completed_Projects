//By extending the generic HTMLElement class, you can create any kind of element you want. 
//It's also possible to extend specific elements like HTMLParagraphElement.

class Notecontent extends HTMLElement {
    constructor() {
      super();
   }
  
   connectedCallback() 
   {
    this.innerHTML = `
    <span class="card-body" id="cardBody">
        <h2 id="titleOfNote">S</h2>
        <p class="card-text" id="cardContent">L</p>
        <p class="card-text"><small class="text-body-secondary">Last updated 3 mins ago</small></p>
      </span>`;
   }
}
customElements.define('notecontent-component', Notecontent);      

    