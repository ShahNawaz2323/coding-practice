#include <iostream>
#include <cstdlib>
#include <string>
#include <vector>
#include <sstream >
#include <limits>

using namespace std ;

void table_fun(int x){
	
	for (int i=1; i<=10; i++ ) {
		
	  cout << x*i <<endl;
	}
	
}

int main ()

{
	cout <<"give valuse which you want table: " ;
	int y ;
	cin >> y ;
	
	table_fun(y) ;
	
	return 0 ;
}

