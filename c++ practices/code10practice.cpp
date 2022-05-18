#include <iostream>
#include <cstdlib>
#include <string>
#include <vector>
#include <sstream >
#include <limits>

using namespace std ;

int main()
{
	
   char Sage = 0 ;
	
	cout << "Enter your age: " ;
	
	 cin >> Sage ;
	 
	 
	 int nage = Sage ;
   
   
    if ((nage >= 1) && (nage <=18 )) {
    	
    	cout << "It's important birthday " ;
    	
	 } 
	 
	 
	 else if ((nage <= 21) || (nage <=50 )){
	 	
	 	cout << "It's also a important birthday!" ;
	 }	
	 
	  
	 
	 else {
	 	cout << "Sorry to old not important birthday " ;
	 }
	 
	
	return 0 ; 
}
