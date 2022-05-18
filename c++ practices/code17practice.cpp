// Program to calculate Farnhiet tempreture from Centigrade

// centigrade to fahrenheit Conversion Program

//add standard I/O library fuctions

#include <iostream>

using namespace std ;

// global function 

      
	  void convert_fun (float x){
 	
 // formula for conversion
 
  float result ;
      
	  	result = (x * 9/5) + 32 ;
	  	
	  	cout << "Tempreture in Farnheit : " << result ; 
 	
 }

// starting of main function 

   int main  () {
   	
   	float y ;
   	
   	cout << "Enter The Tempreture in the Centigrades : " ;
   	
   	// taking input from the user 
   	
   	cin  >> y ;
   	
   	convert_fun ( y ) ;
   	
   	
   	
   	// Terminate the main functon by sending zero to OS ;  .......]
   	
   	return  0 ;
   	
   	
   }

