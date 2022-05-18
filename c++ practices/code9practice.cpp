#include <iostream>

using namespace std ;

   swap (int c , int d)
  {
  	
  	int temp ;
  	temp = c ;
  	d = c ;
  	c = d ;
  }
int main ()
{
	
 int a =10, b=40 ;
 

      cout << "before a is: "<<a << endl ;	
	
      cout << "before b is: "<<b << endl ;
      
      swap  (int c ,int d ) ;
 
   /*  
     cout << "a is: "<< a+b<<endl ;
     cout << "b is: "<< a-b<<endl ;
     cout << "a is: "<< a-b<<endl ;
	 a = a+b ;
	 
	 b = a - b ;
	 
	 a = a - b ;
     */ 
      cout << "\n Aftert a is: "<<a << endl ;
      
      cout << "\n after b is: "<<b << endl ;
	  
	  	
 	
 	
 	return 0 ;
}
