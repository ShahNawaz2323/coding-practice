// file Handling 

#include <iostream>
#include <fstream>

using namespace std ;

int main () {
	
	ofstream filestream("testout.txt") ;
	
	if (filestream.is_open()) {
		
		
		
		filestream << "Welcome to the programming.\n" ;
		filestream << "Welcome to the C++.\n" ;
		filestream.close() ;

	}
	
   else cout <<	"File opening is fail " ;
   
   
   
   
   return 0 ;
	
	
	
}
