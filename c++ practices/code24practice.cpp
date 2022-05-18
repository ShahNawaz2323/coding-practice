//Program to understand Constructor declaring and Constructur calling
#include <iostream>

using namespace std ;

class MyPrac{
	//class staring with default access spacifier of Privete 
	
	public: 
	
	//Creating Class Constructor with using of class name
	    MyPrac(string nm){
	    	
	    	setName(nm) ;
		} 
	
	      void setName(string x) {
	      	
	      	name = x ;
	      	
		  }
		  string getName() {
		  	
		  	return name ;
		  }
		  
	private:
	      // Do Encapsulation , Privte authenticate value 
		  
		  string name ;	  
	
};

// main function of the Program 

int main() {
	
	//Check Running state of the program 
	
	cout << "Running Okay! .... :  " << endl ;
	
	// Create Class Objects in followings ways 
	
	MyPrac obj1("ShahNawaz") ;
	MyPrac obj2("Zain") ;
	
	cout << "Account 1 holder Name: " <<obj1.getName() <<endl ;
	
    cout << "Account 2 holder Name: " <<obj2.getName() <<endl ;	
	
	//By pass the get set values access illegally 
	//Not Illelagal it's correct standard way of calling
	
	MyPrac obj3("shahnawazWarriach") ;
	
	cout<< "Account 3 holder Name: " << obj3.getName() << endl ;
	
	return 0 ;
}
