/*
 - Members: Ali Hassan Mahdi, Chilka Patel, Ifham Buhary
 - Date: July 15, 2019
 - Program name: Temperature Reporter
 - Description: This program demonstrates the user of arrays and pointers.
                It takes a set of Celsius temperature from the from the user
                and displays them in a well-formatted output along with the Fahrenheit value.
 */


#include <iostream>
#include <iomanip> // used for setprecision()
using namespace std;

// Converts celsius temperature to fahrenheit
inline double convertToFahrenheit(double celsius);

// Display's the temperature array in a well-formatted output
void displayReport (double *temperatureArray, int days);


int main() {
    
    double *temperatureArray; // array to store the temperatures
    int days; // number of days for temperature entry
    double temperature; // user's input for temperature
    const int MIN_DAYS = 1; // minimum number of days allowed
    const int MAX_DAYS = 365; // max number of days allowed
    const int MIN_TEMP = -90; // minimum temperature
    const int MAX_TEMP = 60; // max temperature

    // Take the input for number of days
    cout << "How many days do you wish to enter? ";
    cin >> days;
    
    // If input is invalid, e.g not numeric, ask for input again.
    while (cin.fail()){
        
        // reset the flag
        cin.clear();
        
        // clear any unwanted characters from the input stream
        cin.sync();
        
        // Ask user to re-enter the days
        cout << "\n* Invalid input. Please try again and enter a numeric value\n\n";
        cout << "How many days do you wish to enter? ";
        cin >> days;
    }
    
    // Check if the input is within range, otherwise ask the user to re-enter it
    while (days > MAX_DAYS || days < MIN_DAYS){
        
        cout << "\n* Invalid input. Please try again and enter a value between 1 and 365\n\n";
        cout << "How many days do you wish to enter? ";
        cin >> days;
        
        // If input is invalid, e.g not numeric, ask for input again.
        while (cin.fail()){
            
            // reset the flag
            cin.clear();
            
            // clear any unwanted characters from the input stream
            cin.sync();
            
            // Ask user to re-enter the days
            cout << "\n* Invalid input. Please try again and enter a numeric value\n\n";
            cout << "How many days do you wish to enter? ";
            cin >> days;
        }
    }
    
    try {
        // dynamically initialize the temperature array
        temperatureArray = new double[days];
    } catch (bad_alloc) {
        cout << "\n***** Error allocating memory *****";
        system("PAUSE");
        return 0;
    }
    
    cout << "\n\nTEMPERATURE REPORTER\n";
    cout << "===========================\n";
    cout << "Please enter the Celsius temperature for each day\n\n";
    
    // Prompt the user to enter the temperature for each of the days
    for (int i = 0; i < days; i++) {
        
        temperature = 0;
        
        cout << "Day " << (i+1) << ": ";
        cin >> temperature;
        
        // If input is invalid, e.g not numeric, ask for input again.
        while (cin.fail()){
            
            // reset the flag
            cin.clear();
            
            // clear any unwanted characters from the input stream
            cin.sync();
            
            // Ask user to re-enter the temperature
            cout << "\n* Invalid input. Please try again and enter a numeric value\n\n";
            cout << "Day " << (i+1) << ": ";
            cin >> temperature;
        }
        
        // Check if the temperature is within range
        while (temperature > MAX_TEMP || temperature < MIN_TEMP){
            cout << "\n* Invalid input. Enter a value between -90 and 60\n\n";
            cout << "Day " << (i+1) << ": ";
            cin >> temperature;
            
            while (cin.fail()){
                
                // reset the flag
                cin.clear();
                
                // clear any unwanted characters from the input stream
                cin.sync();
                
                // Ask user to re-enter the temperature
                cout << "\n* Invalid input. Please try again and enter a numeric value\n\n";
                cout << "Day " << (i+1) << ": ";
                cin >> temperature;
            }
        }
        
        // Store the temperature in an array
        temperatureArray[i] = temperature;
    }
    
   // Display the temperature report
    displayReport(temperatureArray, days);
    
    // Delete the temperature array
    delete [] temperatureArray;
    
    system("PAUSE");
    return 0;
}

// Display's the temperature array in a well-formatted output
void displayReport (double *temperatureArray, int days){
    cout << "\nDAILY TEMPERATURE REPORT\n";
    cout << "===========================\n";
    
    // Loop through the array and display the temperature
    for (int i = 0; i < days; i++) {
        
        double celsius = *(temperatureArray+i); // pointer notation
        double fahrenheit = convertToFahrenheit(celsius); // calculate the fahrenheit value
        // Display the fahrenheit and celsius temperatures to the user
        cout << "Day " << (i+1) << "\t" << setw(10) << fixed << setprecision(2) << fahrenheit << "°F" << "\t" << setw(10) << fixed << setprecision(2) << celsius << "°C" << endl;
    }
}

// Converts celsius temperature to fahrenheit
inline double convertToFahrenheit(double celsius){
    return (celsius * 9/5) + 32;
}



