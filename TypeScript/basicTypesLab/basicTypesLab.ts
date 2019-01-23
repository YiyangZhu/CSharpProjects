let color: string;
color = "green";
let squareSizeNum: number;
squareSizeNum = 100;

let squareSize: string = `${squareSizeNum}px`;
//Template strings(strings contained within backtick keys) can reference Number type variables from within String type
//variables to interpolate them with ${}.

let button: Element = document.createElement('button');
let div: Element = document.createElement('div');
/*The Element types in TS is a built in set of types for dealing with manipulating the Document Object Model
or DOM(Document Object Model (DOM) is a platform and language-neutral interface that allows programs and 
scripts to dynamically access and update the content, structure, and style of a document.). It essentially
represents a subset of what an HTML element can do natively in JS.
Finally, add some text to the button, and then append those elements to our document.body - which is the
<body> tag in the standard HTML document that we set up in the Lab Setup Instructions.
*/
button.textContent = "Change Color";
document.body.appendChild(button);
document.body.appendChild(div);

let colorChange: Function = (elem: Element,color: string): boolean => {
    elem.style.backgroundColor = color;
    return true;
}




