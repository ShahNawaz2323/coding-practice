//classes inheritance 
//program to practice Parent child class inheritance usage

//calling standard input output libraries
#include<iostream>
//adding stadard library for string long text
#include<string>

//standard of naming
using namespace std ;

//create a parent class name Parent Class
class Parent{
	
	string str ;
	
	// creating a main class function which we call in the daughter class
	//set type public because by default it's become privte
	public:
		//public the constructor of that class
		Parent(){
		} ;
		//create unction 
		void sayHi(){
			//body of the function sayHi
			
			cout<< "\n  Hi! , How are you? " <<endl ;
			
			cin >> str ;
			
			cout<<"You just strting dive down in digital world "<<endl
			    << "         Congratulations! " ;
		}
};
//now creting a daughter class 

class daughter : public Parent{
	
	//that is empyty class but can inherit all data members  and functions of the class Parent
	public:
	//public the constructor of that class
		daughter(){
		} ;
	
};

// now we operator overloading in the that new  class
class NewClass{
	public:
		NewClass(int a) : var(a)
		{
				 
			
		}
		
	//these are the different way to access member varible values
	//create function first 
	printFunc() {
	
	cout<<"\n\n******There is three same outputs with diffferent implementation methods.:******** "
		<<"\n          Method 1  : " <<var 
	    <<"\n          Method 2  : " <<this->var 
	    <<"\n          Method 3  : " <<(*this).var  ;
}


	private:
		int var ; //later we overload int operator use var as int operator 
		
};


//starting main function of that Program
int main() {
	
	// creating object of the daughter class to start program and get output
	daughter a  ;
	//a is the object of class daughter and now we can call parent class functions
	a.sayHi() ;
	
	//newclass object and calling 
	NewClass obj(423)  ;
	obj.printFunc();
	
	
	//return type set when program exit
	return 0 ; 
}
