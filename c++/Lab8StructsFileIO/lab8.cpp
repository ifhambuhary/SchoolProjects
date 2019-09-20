/*
*	Members: 		Ali Hassan Mahdi, Chilka Patel, Seyed Ifham Buhary
*	Program name: 	Lab 8 –Structs and File I/O
*	Date:			August 15, 2019
*	Description:	This program reads a set of employee data from an input file, stores them in a structure,
*					and outputs their name and total pay in a new file
*/

#include <iostream>
#include <fstream>    // needed for ifstream class
#include <string>	// for c_str()
#include <iomanip> // used for setw()


using namespace std;

// Custom structure that holds the first name, last name
// number of hours worked, and the hourly wage of an employee
struct PayRecord {
    string firstName;
    string lastName;
    double hoursWorked;
    double wage;
};

int main() {
    
    const string FILENAME = "hours.txt"; // name of the input file
    ifstream inFile;        // an ifstream object to connect to the file
    string fileLine; // holds the line read from the file
    int returnValue = 0;     // holds the return value for main()
    
    // Open the input file
    inFile.open(FILENAME.c_str());
    
    if(inFile.fail()) // If the input file could not be opened
    {
        // Inform the user
        cout << "\nThe file was NOT successfully opened. "
        << "Check that the file exists" << endl;
        
        // set the return value of main() to 1
        returnValue = 1;  // '1' indicating the program did not
        // execute successfully
    } else
    {
        
        ofstream outFile;		// an ofstream object to connect to the file
		const string OUTPUTFILE = "pay.txt"; // name of the output file
        outFile.open(OUTPUTFILE.c_str()); // Open the output file

        if(outFile.fail()) // If the output file could not be opened
	 	{
	 		// Inform the user
			cout << "\nThe " << OUTPUTFILE << " file was NOT successfully opened for output." << endl;
			// set the return value of main() to 1
			returnValue = 1;  // '1' indicating the program did not 
	 	 				      // execute successfully
	 	} else {
	 		// Write the structured data to the output file
	 		outFile << "ALI HASSAN MAHDI" << endl;
	 		outFile << "PAY FOR THIS WEEK" << endl;
				outFile << "==========================" << endl << endl;
	 		
	 		double totalPay = 0; // Stores the combined total pay of all employees
	 		// While not end of file
	 		while(inFile.good())
		        {
		            PayRecord pay; // Declare a variable of PayRecord structure
		
		            inFile >> pay.firstName >> pay.lastName >> pay.hoursWorked >> pay.wage;
		            
			    	// **set the output file stream formats
					outFile << setiosflags(ios::fixed)
					<< setiosflags(ios::showpoint)
					<< setprecision(2);
					
					// Calculate the pay amount of the employee
					double payAmount= pay.hoursWorked*pay.wage;
					
					// Add the pay to the combined total pay
					totalPay += payAmount;
					
					// Store the formatted employee name in a string
					string dot = ". ";
					string name = pay.firstName.at(0) + dot + pay.lastName;
					
					// Write the employee record on a new line in the output file
		            outFile << setw(13) << right << name << setw(4) << right << "$" << setw(9) << right << payAmount << endl;
		            
		      }
		      
		    
				outFile << endl << "==========================" << endl;
				outFile << setw(18) << right << "Total: " << "$" << totalPay;
		        
		      inFile.close(); // close the input file.
		      outFile.close(); // close the output file.
		        
		 }
        
    }
    
    system("PAUSE");
    return returnValue;
}
