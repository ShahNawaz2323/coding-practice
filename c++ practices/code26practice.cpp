//C++ Structure practice

#include <iostream>
#include <string>

using namespace std ;



struct Person{
	

string name;

int age ; 


float salary ;






} ;

int main() {
	//define the structure variable
	
	Person bill ;
	
	
	
	//acess the member of structur
/*	
	bill.name ;
	bill.age ;
    bill.salary;
  */
    
    cout <<"////********************************************************************//////\n" ;
    
    cout << "***********************Give Details \n" << endl ;
    
     cout <<"Give Name Please: " ;
	cin >> bill.name ; 
	cout <<endl;
	
	cout <<"Give age Please: " ;
	cin >> bill.age ; 
	cout <<endl;
	
	cout <<"Give salary amount Please: " ;
	cin >> bill.salary ; 
	cout <<endl;
	
	cout<< "Name is "<<bill.name<<endl ;
	cout<< "Age is "<<bill.age<<endl ;
	cout<< "And Salary is "<<bill.salary<<endl ;
	
	cout <<"////********************************************************************//////\n" ;
	
}
