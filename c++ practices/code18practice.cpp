// Program to Find factorial

// Recursion type program in which we call function many times as we needed


#include <iostream>

//C++ input/output standards

using namespace std ;

// outer int fuction With Recursion 


int factorial(double n){
	
	if (n==1){
		return 1 ;
	}
	
	else {
		return n*factorial(n-1) ;
	}
}

// starting of main function 

int main () {
	
	// output of the Factorial function
	cout <<"Factorial of 5! is : "<< factorial(5)<<endl  ;
	
	cout << endl ;
	
	// Another method to get answer of your desire Factorial number 
	
	int c ;
	
	cout << "Give the number which you want factorial (like 5! write 5 only) :  " ;
	//take input from the user
	
	cin >> c ;
	
	cout << factorial(c) ;
	
	return 0 ; 
}

