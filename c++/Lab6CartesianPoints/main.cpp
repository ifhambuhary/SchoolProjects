/* 
- Members: Ali Hassan Mahdi, Ifham Buhary
- Date: July 23, 2019
- Program name: Cartesian Points with Vectors
- Description: This program is a demonstration of the use of vectors. 
			   It taks a set of different Cartesian points as inputs and 
			   displays the distance between each of them.
*/
#include <iostream>
#include <iomanip> 				
#include <vector> 				// needed for vectors
#include "MyConsoleInput.h" 	// Input validation header
#include "MyCartesianPoint.h" 	// CartesianPoint class header

using namespace std;

// This function calculates the distance between each points and returns the sum of the distances
double TotalDistance(const vector<CartesianPoint> & POINTS);

int main(){

try 
{


const int LIMIT = 10; // The limit allowed for x and y input
CartesianPoint START_POINT = CartesianPoint(0,0); // starting point
CartesianPoint END_POINT = CartesianPoint(LIMIT,LIMIT); // end point
START_POINT.SetLimit(LIMIT); // Set the coordinate limit for the starting point
END_POINT.SetLimit(LIMIT); // Set the coordinate limit for the end limit
vector<CartesianPoint> pointsVector; // Vector that holds the cartesian coordinates
pointsVector.push_back(START_POINT); // Add the first starting point to the vector



CartesianPoint userInput = CartesianPoint(); // CartesianPoint object that will hold the current user input

cout << "You will be travelling from (0, 0) to (10, 10) in as many steps as you like. Enter (10, 10) to end.\n\n";	

do{
	
	CartesianPoint lastPoint = pointsVector.back(); // last element of the vector
	int x, y;
	
	// Prompt the user to enter the coordinate of the new point
	cout << "Move from " << lastPoint.ToString() << " to where?\n";
	cout << "X: ";
	x = ConsoleInput::ReadInteger(LIMIT*-1, LIMIT);
	cout << "Y: ";
	y = ConsoleInput::ReadInteger(LIMIT*-1, LIMIT); 
	cout << endl;
	userInput.SetPoint(x,y);
	pointsVector.push_back(userInput); // Add the user's input to the vector

} while(userInput.GetX() != 10 || userInput.GetY() != 10); // Continue taking input until the user enters (10,10)

// Compute the total distance of the points
double totalDistance = TotalDistance(pointsVector);

cout << "\nThe total distance between " << pointsVector.size() << " points is " << fixed << setprecision(2) << totalDistance << endl << endl;

} catch(exception &ex){
		cerr << "\nAn error occurred: " << ex.what();
}


system("PAUSE");
return 0;

} // end of main method

// Calculate and display the distance between each points
// Return the sum of the distances
double TotalDistance(const vector<CartesianPoint> & POINTS)
{

double totalDistance = 0;
CartesianPoint fromPoint; // CartesianPoint object that is the point we are calculating the distance from 

// loop through the vector and display each point and the distance. 
for (int i = 1; i < POINTS.size(); i++){
		fromPoint = POINTS[i-1]; // From distance will be the previous point
		CartesianPoint toPoint = POINTS[i]; // toPoint will be the current point
		
		double distance = fromPoint.GetDistanceTo(toPoint); // get the distance between the from point and to point
		totalDistance += distance; // Sum the distance between the from point and to point 
		 
		// Display the points and distance in a well format to the user
		cout << fromPoint.ToString() << " -> " << toPoint.ToString() << ": " << fixed << setprecision(2) << distance << endl;
}

return totalDistance; 

}


