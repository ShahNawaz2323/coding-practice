//stock market simulater 

#include <iostream>
#include <cmath>
using namespace std ;

// Create a new class 
class stock{
	
// make public because by default it is private
public:
	
	//constructor 
	double Stock (float a , float p, float r){

/*	  
	 a = alpha12 ;
	 p = beta23 ;
	 r = gama23 ;
	 
	 
*/	 
		
	for (int day= 1 ; day<=30; day++){
		
		a = p * pow (1+r, day) ;
		
		cout << day << " ------- "<< a << endl ;
	}	
	  
	}
	
/*private:
      float   alpha12 ; 
	  float beta23 ;
	  float  gama23 ;
	  
	   
*/	 
	   
	
};

//starting main function

int main(){

//create stock class object 
stock x ; 	
x.Stock(0 , 10000 ,0.03) ;
	
return 0 ;	
	
}
