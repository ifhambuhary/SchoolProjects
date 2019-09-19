/* *************************************************************************************	
*	Lab 1 - Getting Started
*
*	In this console C++ program the user be prompted to enter the x and y
*	coordinates of two Cartesian1 points. The program will then calculate 
*	and display the distance between them. 
*	
*	Author 	- 	Ifham Buhary
*	Date	-	05/18/2019
*	
*****************************************************************************************/

#include <iostream>											//To use cin and cout 
#include <cmath>											//To use math functions
	
using namespace std;

int main()
{
	//DECLARATIONS
	int x1, x2, y1, y2;
	double distanceCalculated;
	
	cout << "Enter values for x1 and x2: ";					//Prompt for Input for Value x
	cin >> x1 >> x2;										//Store the Value in x1, x2
	
	cout << "\nEnter values for y1 and y2: ";				//Prompt for Input for Value y
	cin >> y1 >> y2;										//Store the Value in y1, y2
	
	distanceCalculated = sqrt(pow(x2-x1,2)+pow(y2-y1,2));	//Calculate the Distance
	
	cout << "\nThe Distance between the two points is " << distanceCalculated << "." << endl;	//Output the Value
	
	system("pause");
	return 0;
}


