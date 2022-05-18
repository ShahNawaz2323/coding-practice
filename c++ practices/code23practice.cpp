// Access specifier Programing Practice 
// Seter And Geter Functions 

#include <iostream>
#include <string>

using namespace std ;

// Declaring class with Encapsulation

class data_01{
	
	public:
		//setter function to set value 
		
		void setData(string x) {
		
		
		name = x ;
	}
	//Get_data From the private sector 
	//through get data Function
		
	const	string getData() {
		
		
		return name ;
}
	private:
	 
	    string name ;	
	
	
};

// staring of main Function 

int main(){
	
	//Object Declare of the class data_01
	data_01 obj_01 ;
	// calling class function through class object
	obj_01.setData("ShahNawaz") ;
	
	//get out-put through get_data
	
	cout << "Name Is: " <<obj_01.getData() ;
	
	
	// return 0 to Terminate the program 
	
	
	return 0 ;
	
	
}
