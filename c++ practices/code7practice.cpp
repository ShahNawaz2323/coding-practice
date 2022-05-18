#include <iostream> 

using namespace std ;


void print_function (int &roll , float &gpa) {

	
	cout << roll <<"\n"; 
	
	cout << gpa <<"\n";
	
	roll = 10 ;
	
	gpa = 20.2 ;
	
}

int main()
{
	
	int Roll_no ;
	
	float Gpa ;
	
	cin >> Roll_no ;
	
	cin >> Gpa ;
	
	print_function(Roll_no , Gpa) ;
	
	
	cout << Roll_no <<"\n" ;
	
	cout << Gpa<<"\n" ;
	
	return 0 ;
	
}



