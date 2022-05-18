//Exprimental studies 
//Program to Calculate in C++ CGPA

#include<iostream>

using namespace std ;

int main(){
	//testing
	cout<<"\nPogram to Calculate CGpa:\n"<<endl ;
	
	//Demo Single testing 
	
    
    int sub = 0 ;
    float qu ;
    float e = 0 ;
    float GRADE_POINTS ;
    const int CR_HRS = 3 ;
    float QUALITY_POINTS ;
	float total=0 ;
	float cgpa ;
	char again = 'Y' ;
	
	const float a = 4.0 ;
	const float b = 3.0 ;
	const float bb = 3.5 ;	 
    const float c = 2.0 ;
    const float cc = 2.5 ;
    const float d = 1.0 ;
    const float dd = 1.5 ;
    
    //loop to run program again and again in the running window 
    
    while (again =='y' || again == 'Y') {
	
    
    
    cout<<"*************User Manual How to Use Program*******"<<endl;
    cout<<"**************************************************"<<endl;
    cout<<"*************For Gpa A input 4,   and A+ are same*"<<endl;
    cout<<"*************For GPa B+ input 3.5*****************"<<endl;
    cout<<"*************For Gpa B input 3********************"<<endl;
    cout<<"*************For GPa C+ input 2.5*****************"<<endl;
    cout<<"*************For Gpa C input 2********************"<<endl;
	cout<<"*************For GPa D+ input 1.5*****************"<<endl;
    cout<<"*************For Gpa D input 1********************"<<endl;
	cout<<"**************************************************"<<endl;
	
	cout<<"\n How Many Subject for you want to calculte CGPA : " ;
	cin >> sub ;
	 for(int i=1 ; i<=sub ; i++)
	{
		

		cout <<"NO : " << i << " ****************""Enter The Gpa between 1 to 4 ******";
		
		cout << ": ";
		
		cin >> GRADE_POINTS ;
		
		
		
		
		QUALITY_POINTS = QUALITY_POINTS + GRADE_POINTS * 3 ;
		
		total =+ QUALITY_POINTS ;
	

		
		
	}  //for loop end here
	
	
	cout<< "\n       Total Quality Point is : "<< total ; 
	cgpa = total/ (sub*3) ;
	cout << "\n Total Credit yours is : "<< sub*3 ;
	cout<< "\n       CGPA IS  : "<< cgpa<<endl  ;
	
	
    cout<<"   **************************************************"<<endl;
    cout<<"   *************Run Again? (y/n) Answer********** :  "<<endl;
    
    cin >> again ; //input y or n to run stop Program
	
	
}  //end of while loop

	cout << "\n\n ********************   Thank Allah , Successfully ,Verified result in Testing Environment" <<endl ;
	
	return 0 ;
}
