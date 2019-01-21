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

/*
TypeScript is a structural type system. When we compare two different types, regardless of where they came from,
if the types of all members are compatible, then we say the types themselves are compatible.
However, when comparing types that have private and protected members, we treat these types differently. For
two types to be considered compatible, if one of them has a private member, then the other must have a private 
member that originated in the same declaration. The same applies to protected members.
*/
class AnimalThree{
    private name: string;
    constructor(theName: string){this.name = theName};
}

class Rhino extends AnimalThree{
    constructor(){super("Rhino");}
    public getName(){
        return `Hello, my name is ${this.name}`; // Error! name is private and is only accessible within class "AnimalThree"
    }
}

class Employee{
    private name: string;
    constructor(theName: string){this.name = theName;}
}

let animal = new AnimalThree("Goat");
let rhino = new Rhino();
let employee = new Employee("Bob");

animal = rhino;
animal = employee; //Error. Types have separate declarations of a private property 'name'.
/*
Rhino is a subclass of AnimalThree. Employee class looks identical to AnimalThree in terms of shape.AnimalThree 
and Rhino share the private side of their shape from the same declaration of private name: string in Animal,
they are compatible. However, this is not the case for Employee. When we try to assign from an Employee to Animal
we get an error that these types are not compatible. Even though Employee also has a private member called name,
it is not the one we declared in AnimalThree.
*/
//Example of compatible types:
class AnimalFive{
    name:string;
    constructor(n:string){
        this.name = n;
    }
}

class Computer{
    name: string;
    constructor(n:string){
        this.name = n;
    }
}

let animalFive = new AnimalFive("animal five");
let computer = new Computer("computer one");
animalFive = computer; // compatible types -- no errors
computer = animalFive; // compatible types -- no errors

/*
Protected is much like the private modifier with the exception that members declared protected can also be 
access by instances of deriving classes.
*/
class Person{
    protected name: string;
    constructor(name: string){
        this.name = name;
    }
}

class EmployeeTwo extends Person{
    private department: string;

    constructor(name: string, department: string){
        super(name);
        this.department = department;
    }

    public getElevatorPitch(){
        return `Hello, my name is ${this.name} and I work in ${this.department}.`; //as name is protected, it can be accessed within derived class. so no errors...
    }
}

let howard = new EmployeeTwo("HOward","Sales");
console.log(howard.getElevatorPitch());
console.log(howard.name);//name is protected and only accessible within class "Person" and its subclasses.
/*
Notice that while we can't use name from outside of Person, we can still use it from within an instance method
of Employee because Employee derives from Person.
A constructor may also be marked protected. This means that the class cannot be instantiated outside of its
containing class, but can be extended.
*/
class PersonThree{
    protected name: string;
    protected constructor(theName: string){
        this.name = theName;
    }
}

class EmployeeThree extends Person{
    private department: string;
    constructor (name: string, department: string){
        super(name); // no errors ,as contructor in PersonThree is protected, which means can be accessed in subclasses.
        this.department = department;
    }

    public getElevatorPitch(){
        return `Hello, my name is ${this.name} and I work in ${this.department}.`;
    }
}

let howardThree = new EmployeeThree("Howard","Sales");
let johnThree = new PersonThree("John"); //constructor in EmployeeThree is protected and only accessible within the class and its subclasses.

/*
use the readonly keyword to make properties readonly. Readonly properties must be initialized at their declaration
or in the constructor.
*/
class Octopus{
    readonly name: string;
    readonly numberOfLegs: number = 8;
    constructor(theName: string){
        this.name = theName;
    }
}
let dad = new Octopus("Man with the 8 strong legs.");
dad.name = "Man with the 3-piece suit"; //Error. Name is readonly.

//parameter properties, a further revision of the previous Octopus class using a parameter property
class OctopusTwo{
    readonly numberOfLegs: number = 8;
    constructor(readonly name: string){
    }
}
//We dropped theName altogether and just use the shortened readonly name: string parameter on the constructor
//to create and initialize the name member. Parameter properties are declared by prefixing a constructor parameter
//with an accessibility modifier or readonly, or both. Using private for a parameter property declares and initializes a private member;
// the same is done for public, and readonly.








