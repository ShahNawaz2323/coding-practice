// starting of new program to see power function

#include <iostream>
#include <cmath>
#include <string>

using namespace std ;

// starting of main function

int main ()


{
	
	double  u , v ;
	
	string str ;
	
	cout << "2 is the power of 6 : " 
	     << pow(2.0, 6.0)
	     << endl ; 
	     
	cout << endl ;
	
	u = 12.5 ;
	v = 3.0 ;
	
	cout << u <<" to the power of the " << v
	     << "= " << pow(u , v) << endl ;
		 
		      
	cout << endl ;
	
	cout << "square root of 24 is  : "
	     << sqrt(24.0)
	     << endl ;
	     
    cout << endl ;
    
    
    
    u = pow(8.0, 2.5) ;
    
    cout << "new rule  u is  : " << u << endl ;
    
    cout << endl ;
    
    str = "hamza warriach" ;
    
    cout << "length of variable of string is : "
         <<  str.length() 
         <<    endl ;
         
         
         
   cout << endl ;
   
   cout << "My name is " << str << endl ;
   
   cout << endl ;
   
   cout<<"  your name please: " ;
   cin >> str ;
   
   cout << endl ;
   
    
    cout<<" name is " <<str<<endl ;
    cout << endl ;
    
    cout <<"hello "<< str ;
    
	
	return 0 ;
}
