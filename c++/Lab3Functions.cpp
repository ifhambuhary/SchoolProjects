/*
			Program Name: Grade Point Average Calculator
			Author(s): Ifham Seyed Buhary, Alyxander Byfield
			Due Date: June 9, 2019

			Program summary:

				The user will enter a numeric value between 0 - 100 and will be shown
				the equivalent amount of grade points. They program will continue until the
				value -1 is entered. At which point it will end.


			Dev notes:

				Any and all processing must take place in a 'GradePoints()' function. 

				The 'Main()' function will:
				- Take in the grade input
				- Check if the input is within range, otherwise display an out of range error.
				- Will do no further validation.
				- Ends the loop and program if the input is -1
				- round userInput to the nearest whole number

				The 'GradePoints()' function will:
				- Check if the input is within range
				- determine the equivalent grade points and print to the screen



				90 - 100 = 5.0
				85-89 = 4.5
				80-84 = 4.0
				75-79 = 3.5
				70-74 = 3.0
				65-69 = 2.5
				60-64 = 2.0
				55-59 = 1.5
				50-54 = 1.0
				>50 = 0.0 Fail
*/

//#include "pch.h"
#include <iostream>
#include <iomanip>
#include <math.h>

using namespace std;

//FUNCTION PROTOTYPES
double GradePoints(double);

//-------------------------------------------------
int main()
{
	//VARIALBES

	double gradeInput = 0.0;		//Stores user input to be passed to GradePoints()
	double gradePoints = 0.0;		//The calculated GPA calculated by GradePoints() and outputted
	int loop = 1;					//Determines whether the loop's value will be true or false
	
	const int MAX_RANGE = 100;
	const int MIN_RANGE = 0;
	
	cout << "\t\t\t\t*****************************************************"
		 << "\n\t\t\t\t*********** WELCOME TO OUR GPA CALCULATOR ***********" 
		 << "\n\t\t\t\t*****************************************************" << endl; 

	// Begin encasing do-while loop structure 
	do
	{
		cout << "\nPlease enter the grade to be calculated (or -1 to exit): ";

		cin >> gradeInput;

		if (cin.fail()) // The input is not a number!
		{
			cout << "The input must be a number. Please try again..." <<endl;

			cin.clear();
			cin.sync();		
		}
		else if (gradeInput == -1) //The user has entered the value to end the program
		{
			cout << "\nThank you for using our program! Press any key to exit..."<<endl;
			break;
		}
		else // Input is valid and program continues
		{
			//Check if gradeInput is within range
			if(gradeInput < MIN_RANGE || gradeInput > MAX_RANGE)
			{
			cout << "Invalid Grade. Grade must be between " << MIN_RANGE << " & "  << MAX_RANGE <<"."<<endl;
			}
			else
			{
			//round(gradeInput);
			
			gradePoints = GradePoints(round(gradeInput));

			cout << "A grade of " << fixed << setprecision(1) << round(gradeInput) << "% is equal to " << gradePoints << " grade points." << endl;
			}
		}
	} while (loop = 1);	// 1 = true, 0 = false   
}

double GradePoints(double gradeInput)
{
	double gradePoints = 0.0;
	//Processing				
		if(gradeInput >= 90)
		{
			gradePoints = 5.0;
		}
		else if(gradeInput >= 85)
		{
			gradePoints	= 4.5;
		}
		else if(gradeInput >= 80)
		{
			gradePoints = 4.0;
		}
		else if(gradeInput >= 75)
		{
			gradePoints =3.5; 
		}
		else if(gradeInput >= 70)
		{
			gradePoints = 3.0;		
		}
		else if(gradeInput >= 65)
		{
			gradePoints = 2.5;		
		}
		else if(gradeInput >= 60)
		{
			gradePoints = 2.0;		
		}
		else if(gradeInput >= 55)
		{
			gradePoints = 1.5;	
		}
		else if(gradeInput >= 50)
		{
			gradePoints = 1.0;	
		}
		else
		{
			gradePoints = 0.0;				
		}	
				
	return gradePoints;
}

