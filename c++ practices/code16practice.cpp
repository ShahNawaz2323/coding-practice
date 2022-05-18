// This Program include 3 total sub programs

// Remove carefully the multi line comments to see different Program


#include <iostream>

using namespace std ;

// Table Through passing values , use of function


// Program 3
         
         void table_func(int x ){
         	
         	for (int i=1 ; i<=10 ; ++i ){
         		
         	cout << x << " * " << i <<" = " << x * i << endl ;	
			 }
         	
		 }
		 
		 
         

int main(){
	
	// program 3 
	
	
	
	
	
	int y ;
	
	cout << "Enter a positve integer : " ;
	
	cin >> y ;
	
	// calling the void function get result by passing value
	
	table_func( y ) ;
	
	
	
	
	
	
	
	//with simple style in the main function declartion
	
	//Program 1
 
   
   //Program 1 :
   
   /*
	int a ;
	
	cout << "Enter a positve integer : " ;
	cin >> a ;
	
	for (int i=1 ; i<=10 ; ++i) {
		
		cout << a << " * " << i <<" = " << a * i << endl ;
		 
	}
	
	
		*/
	
	
	
	
	// by setting range of your table 
	
	//Program 2
	
	
	/*
		int a ;
		
		int range ;
		
	
	cout << "Enter a positve integer : " ;
	cin >> a ;
	
	cout << "Enter range of your table : " ;
	cin >> range ;
	
	for (int i=1 ; i<= range ; ++i) {
		
		cout << a << " * " << i <<" = " << a * i << endl ;
		 
	}
	

	
	/*
	
	
	
	return 0 ;
	
	
	
	
	
}
