#include <iostream>
#include <cstdlib>
#include <string>
#include <vector>
#include <sstream >
#include <limits>

using namespace std ;

int square_func(int x)
{
	
 
	return x*x;
}

int main()

{
  int y = 0 ;
  cout << "give the number which you want secure: " ;
  cin >> y;
  
  cout <<"SQUARE IS : "<<endl ;
  cout << square_func(y) ;
  
	
	return 0 ;
}
