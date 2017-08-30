// strong typization
let applicationName: string = "first-application-name";
let applicationVersion: number = 21;
let development: boolean = true;

if (development) {
    console.log(applicationName);
    console.log(applicationVersion);
}

// dinamic typization
let increment: any = 5;
console.log(increment++);

increment += "A";
console.log(increment + 1);

// functions
function add(x: number, y?: number, z: number = 5): number { // optional and default values of parameters
    return x + y + z;
}


// classes
class Customer {
    // public fields
    Name: String;
    Adress: String;
    Saved: boolean;

    constructor(name: string, adress: string) { // contsructor
        this.Name = name;
        this.Adress = adress;
    }

    private _age: number;

    // NOTE: properties are supported only since ES5 that's why you should type:
    //       tsc classExample.ts --target es5
    //       for correct compiling

    get age(): number { // getter
        return this._age;
    }

    set age(theAge: number) { // setter       
        console.log('new age received ' + theAge);

        if (theAge < 0 || theAge > 100) {
            throw "Invalid Age"; // exceptions
        }

        this._age = theAge;

        console.log(`new age is ${theAge}`); // string interpolation
    }

    // arrow functions (working with anonymous functions)
    Save(f: () => void): void {
        setTimeout(() => {
            this.Saved = true;
            f();
        }, 100);
    }
}

class GoldCustomer extends Customer { // inheritance
    Discount: number;

    constructor(a: string) {
        super("Gold test", a);
    }
}

let c: Customer = new Customer("Test", "First adress");
c.age = 55;
c.age = -65; // throws exception
console.log(`Customet ${c.Name} lives at ${c.Adress} (his age is ${c.age})`); // string interpolation

// interfaces and abstract classses
interface ILogger {
    LogError(e: string): void;
    SendEmailLog(s: string): boolean;
}

abstract class AbstractServiceInvoker {
    Save() {
        let ServiceURL: string = this.GetServiceURL();
        let Credentials = "UserName:abcd,password:123";
        let data: string = this.getData();

        //Logic for invoking service is written here. 
        let Result: number = 5;  //Let’s assume that it is the value 

        //returned by service
        this.setData(Result);
    }

    abstract GetServiceURL(): string;

    abstract getData(): string;

    abstract setData(n: number): void;
}

class Logger implements ILogger {
    LogError(e: string): void {
        console.log(`error ${e} logged`);
    }

    SendEmailLog(s: string): boolean {
        console.log(`message ${s} sent in email`);
        return true;
    }
}

class CustomerService extends AbstractServiceInvoker {
    GetServiceURL(): string {
        return "http://someService.com/abcd"
    }

    getData(): string {
        return "{CustomerName:'a',Address:'b'}"
    }

    setData(n: number): void {
        console.log(`Success:${n}`)
    }
}

// destructing
let myArray = [1, 2, 3, 4];
let [v1, v2, v3] = myArray;
console.log(`${v1}-${v2}-${v3}`);

// namespaces
namespace MathsExample {
    export function add(x: number, y: number) {
        console.log(x + y);
    }

    function sub(x: number, y: number) {
        console.log(x - y);
    }

    export class MyClass {
    }
}
MathsExample.add(1, 2);