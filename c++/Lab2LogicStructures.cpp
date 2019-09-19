/* *********************************************************************	
*	Lab 2 - Logic Structures
*
*	In this console C++ program the user enters each archer's
*	individual end scores and then displays the total score for each  
*	archer. This program also calculate and display the overall average 
*	end score.
*
*	Author 	- 	Ifham Buhary
*	Date	-	05/28/2019
*	
*************************************************************************/

#include <iostream>											//To use cin and cout 
#include <iomanip>											//For output formatting								

using namespace std;

int main()
{
	//DECLARATIONS VARIATIONS
	const int MIN_VALUE = 0;
	const int MAX_VALUE = 60;
	const int TOTAL_ARCHERS = 3;
	
	int archerCount = 0;
	int roundCount = 0;
	double archerScore = 0.0;				//Holds user input
	double averageScore = 0.0;				//Average Score
	double totalOverallScore = 0.0;			//Total Score of All Archers
	int totalArcherScore = 0;				//Total Archer Score
	int decimalTest = 0;					//To Test Decimal
	
	//Display Header
	cout << endl
		 << "*****************************\n"
		 << "*** LAB 2 - Archer Scores ***\n"
		 << "*****************************\n";
	
	//Loop for archer and increment if input is valid
	for (archerCount = 1;archerCount <= 3;archerCount++)
	{
		//Rest Archer Total Score
		totalArcherScore = 0;
		
		cout << endl
			 << "Archer " << archerCount << "\n"
			 << "------\n";	 
		//Loop for Round	 
		for(roundCount = 1;roundCount <= 4;)
		{
			//Display user to enter Archer Score
			cout << "Enter Round " << roundCount << " Score: ";
			cin >> archerScore;
		
		 	if(cin.fail())
		 	{
		 		//Check if input is numeric
		 		cout << "***** Invalid!!! Score must Numeric. Please Try Again. *****\n" << endl;
				cin.clear();
				cin.sync();
			}
			else 	
			{
				//Check if input is decimal
				decimalTest = archerScore;
				if(decimalTest == archerScore)
				{					
					//Check if input is within the range
					if(archerScore >= MIN_VALUE && archerScore <= MAX_VALUE)
					{			
						//Sum total Score and Increment Round		 
						totalArcherScore += archerScore;						
						roundCount++;
					}
					else		
					{
						//Display if input wasnt within the range
						cout << "***** Invalid!!! Score must be between " 
							 << MIN_VALUE  << " & " << MAX_VALUE << ". Please Try Again.*****\n" 
							 << endl;
					}
				}	
				else	
				{
					//Display input must be whole number
					cout << "***** Invalid!!! Score must whole number. Please Try Again.*****\n" 
							 << endl;
				}
			}			
		 }
		 //Output of each Archer's Score
		 cout << "\n**********************************" << endl
		 << "The Total of Archer " << archerCount << " is " << totalArcherScore << "." <<endl
		 << "**********************************" << endl;
		 
		 //Sum of all Archer Score
		 totalOverallScore += totalArcherScore;		 
			
	}
	//Output of Average Score for all Archers
	averageScore = totalOverallScore / (double)TOTAL_ARCHERS;
	cout << fixed << setprecision(1);
	cout << "\n**********************************" << endl
		 << "The overall average is " << averageScore << "." <<endl
		 << "**********************************" << endl << endl;
		 
	system("pause");

	return 0;
}
