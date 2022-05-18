
#include <iostream>

using namespace std ;

void getScore (int& score) ;
void printGrade (int score) ;

int main()
{
	int courseScore ;
	
	cout << "based on the course score, \n "
	      << " this Program computes the "
	      << "course grade. " << endl ;
	      
	      getScore(courseScore) ;
	      
	      
	      printGrade (courseScore)  ;
    
    
    
    return 0 ;
}


