/*
Traditional JavaScript uses functions and prototype-based inheritance to build up reusable components, but this
may feel a bit awkard to programmers more comfortable with an object-oriented approach, where classes inherit
functionality and objects are built from these classes. Starting with ECMAScript2015, also known as ECMAScript6,
JavaScript programmers will be able to build their applications using this object-oriented class-based approach.
In TypeScript, developers are able to use these techniques.
*/

//a simple class-based example:
class Greeter{
    greeting: string;
    constructor(message: string){
        this.greeting = message;
    }

    greet(){
        return "Hello, " + this.greeting;
    }
}

let greeter = new Greeter("World!");
let button = document.createElement('button');
button.textContent = 'Say Hello';
button.onclick = function(){
    alert(greeter.greet());
}
document.body.appendChild(button);

//The above class has three members: a property called greeting, a constructor, and a method greet.
//this. : a member access
//construct an instance of the Greeter class using new. This calls into the constructor we defined earlier.
//creating a new object with the Greeter shape, and running the constructor to initalize it.

/*
Public by default
In TypeScript, each member is public by default. You may still mark a member public explicity.
*/
class Animal{
    public name: string;
    public constructor(theName: string){ this.name = theName;}
    public move(distanceInMeters: number){
        console.log(`${this.name} moved ${distanceInMeters}m.`);
    }
}

//when a member is marked private, it cannot be accessed from outside of its containing class.
class AnimalTwo{
    private name: string;
    constructor(theName: string){
        this.name = theName;
    }
}
alert(new AnimalTwo("Cat").name); // Error! Name is private and only accessible within class AnimalTwo.


