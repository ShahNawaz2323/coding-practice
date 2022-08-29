console.log("This is a java script file.");

let name0 = "Shah";
let name1 = "Shah";
let name2 = "Shah";
let name3 = "Shah";

// console.log( name0 + " is a good boy");
// console.log(name1 + " is a good boy");
// console.log(name2 + " is a good boy");
// console.log(name3 + " is a good boy");

//code reuseability by using function
function greet(name  = "harry" , greetText = "Greeting from default JS Parameters values"){
    console.log(greetText + " " +name);
    console.log(name + " is a good boy");
}
let greetText = "Welcome, "
greet(name0 );
greet();
greet(name2, greetText);
greet(name3, greetText);

//function another example
function sum(a,b,c){
    let d = a + b + c;
    return d;
}

let returnVal = sum(2,3,4);
console.log(returnVal);



