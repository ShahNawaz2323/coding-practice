 #include <iostream>
 
 using namespace std ;
 
 int main () {
 	
 	int age = 0 ;
 	
 	cout << "Please enter your age for Check: " ; 
 	
 	cin >> age ; 
 	
 	if ((age >= 5) && (age <=7)) {
 		
 		cout << "Can go to play School"<<endl ;
	 }
	 
	 
	 if ((age >= 8) && (age <=12)) {
 		
 		cout << "Can go to play Middle"<< endl ;
	 }
	 
	 
	 if ((age >= 13) && (age <=16)) {
 		
 		cout << "Can go to  HIGH School" <<endl ; 
	 }
	 
	 if ((age >= 17) && (age <=21)) {
 		
 		cout << "Can go to  Collage" ;
	 }
	 
	 if ((age >= 22) && (age <=60)) {
 		
 		cout << "Can go to  UNIVERSITY"<<endl  ;
	 }
	 
	 if ((age <=3) || (age >=61)) {
 		
 		cout << "Babies and too old ones not Allowed "<<endl ;
	 }
	 
	 else {
	 	cout<<"Check again with age limit 5 to 60" << endl ;
	 }
	 return 0 ;
 }
