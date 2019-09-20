/*
 * 	  Lab7_Group7.cpp
 *
 *    @author   Ali Hassan Mahdi
 *    @author   Chilka Patel
 *    @author   Seyed Ifham Buhary
 *    @version  2019.08
 *    @since    3 August 2019
 */

#include <iostream>
#include <iomanip>
#include <cmath>
#include <limits> // numeric_limits
#include <cfloat>  // for limits of a double DBL_MIN and DBL_MAX
#include <string>  // for limits of a double DBL_MIN and DBL_MAX

using namespace std;

namespace Lab7
{
	// This code has been taken from "Other Data Types Activities" in-class submission
    bool IsNumeric(string theString){
    	
              
        bool isDouble = true;
        if(theString.empty())
        {
            isDouble = false;
            
        }
        // else, the string is not empty
        else
        {
            int digitCount = 0; // counts the digits
            int decimalCount = 0; // counts the deimals
            char character;    // for examining each character
            
            // extract the first character
            character = theString.at(0);
            
            // If the first character is not a digit
            if(!isdigit(character))
            {
                // If first character == '.'
                if(character  == '.')
                {
                    decimalCount++;
                }
                // Else, if the first character is not a sign (+/-)
                else if (!(character == '+' || character == '-'))
                {
                    // Then set isDouble to false
                    isDouble = false;
                }
            }
            else // Then the first character is a digit
            {
                // At least 1 digit was found, increment digitCount
                digitCount++;
            }
            
            // For each of the rest of the characters, or until we find the string invalid
            for(int index = 1; isDouble && index < theString.size(); index++)
            {
                // extract the current character
                character = theString.at(index);
                
                // Check if the current character is a digit
                if(isdigit(character))
                    
                {
                    digitCount++;
                }
                else if(character == '.')
                {
                    decimalCount++;
                    if(decimalCount > 1)
                    {
                        isDouble = false;
                        
                    }
                }
                else // current character is not a digit
                {
                    isDouble = false;
                    
                }
            }
            // If there are no digits
            if(digitCount < 1)
            {
                isDouble = false;
            }
        }
        // return whether the string is a double or not
        return isDouble;
    }
    
    // ReadDouble function definition
    // Code taken from classwork submission
    double ReadDouble(const double MIN, const double MAX)
    {
        
        double validNumber = 0.0; // holds the converted user input
        string input = ""; // holds the user input

        cin >> input;       // try to get input
        
        cin.ignore(numeric_limits<streamsize>::max(), '\n');
        		
        if (!Lab7::IsNumeric(input)){
        	
			
			cin.clear(); // Reset the fail() state of the cin object.
			cin.sync();  // clear the buffer 
            
			cout << "\n* \"" << input << "\" is not numeric. Please try again and enter a numeric value\n";

			// Prompt user to enter an input again.
            return Lab7::ReadDouble(MIN, MAX);
            
        }
        
        validNumber = stod(input);

        if(validNumber < MIN || validNumber > MAX)// if value is outside range...
        {
            // report the problem to the user.
            cerr << "\n* \"" << input << "\" is out of range. Please try again and enter a value between "
            << MIN << " and " << MAX << ".\n";
            // Try again by call the function again (recursion)
            validNumber = ReadDouble(MIN, MAX);
        }
        
        return validNumber; // returns a valid value to the calling function.
    }
}

