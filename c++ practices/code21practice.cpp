// Program For Passing by Reference

#include <iostream>

using namespace std ; 

class class12{
	
	// declaring Function in the class 
	public :
		
	void Passing_fun(int *x){
          
		  
		  *x = 100 ;
		  
		  // *x store the dess of the 100 in x 
		  
		  
         	
		  
		  		
		
		
		
		
	}
	
};

int main (){
	
	int var ;
	
	class12 obj ;
	
	obj.Passing_fun(&var) ;
	
	cout << "Value of variable by passing reference : "<<var ;
	
	return 0 ;
}
