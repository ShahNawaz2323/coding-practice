//Program for Understanding Classes and object

// Add standard Library Files and Functions
#include <iostream>

// Add Standard Function for 
  // Simplified the input and output function writing .....
  
  using namespace std ;
  
  //staring of the class
  class BankAccount{
  	// Declare Class With Specifier PUBLIC
  	public:
  		void someFunc(){
  			
  			int x , y , sum ;
  			
  			cout << "Class Practing :  "<<endl  ;
  			
  			cout << "Input Two Integers : " ;
  			
  			cin >> x  ;
  			
  			cout << endl ;

            cout << "Second Intger : " ;  
			
			cin >> y ; 
			
			cout << endl ;
						
  			sum = x+y ;
  			
  			cout << "Sum is : " << sum ;
		  }
  	
  };  // End of the classs bankAccount
  
  // main function of the program 
  
  int main() {
  	
  	// Declaring Class Object 
  	
  	BankAccount sum_1 ;
  	
  	// Calling the function of the class through object in the main Function 
  	
  	sum_1.someFunc() ; 	
  	
  	
  	// Terminate the main program by returnning Value Zero 
  	
  	return 0 ;
  }
