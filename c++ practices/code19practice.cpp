#include <iostream>

using namespace std ;

// default argument and give values function 

  int volume(int l=1 , int w=10 , int h=2 )
  {
  	int multi ;
  	
  	multi = l*w*h ;
  	
  	
     return multi ; 
  	
  	
  }
  
  // starting of main function 
  
  int main(){
  	
  	// declaring variable 
  	
  	int x , y , z ;
  	
  	 cout << "Give the volume otherwise default values is considered: " ;
	   cin >> x >> y >> z ;
	   
	   // function calling and using default argument
	   
	 
  	
  	cout << "volume is:  " << volume () << endl ;
	   
	cout << "volume is:  " << volume (x,y) << endl ;
	   
	cout << "volume is:  " << volume (y,z) << endl ;
	   
	cout << "volume is:  " << volume (x,y,z) << endl ;
	   
	   
	return 0 ;
  }
