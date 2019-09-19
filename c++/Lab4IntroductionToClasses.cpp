/* *********************************************************************	
*	Lab 4 - Introduction to Classes
*
*	A Box class is created, which represents a rectangular cubiod
* 	shape, and its use is demonstrated. 
*	
*	Author 	- 	Alyxander Byfield & Ifham Buhary
*	Date	-	06/22/2019
*	
*************************************************************************/

#include <iostream> 		// cin, cout
#include <iomanip> 			// fixed, setprecision
#include <sstream>			// stringstream
#include <stdexcept> 		// invalid_argument	
#include "MyConsoleInput.h" // ConsoleInput::ReadInteger()

using namespace std;

class Box
{
  public:
	//Default and parameterized constructor. 
    Box(double myHeight = 0.0,double myWidth = 0.0 ,double myDepth = 0.0)
	{	
	
		setHeight(myHeight);
		setDepth(myWidth);
		setWidth(myWidth);
	}
		 
	//Accessors
	double getHeight() const 
	{
		return myHeight;
	}
	double getWidth() const 
	{
		return myWidth;
	}
	double getDepth() const 
	{
		return myDepth;
	}		
	double getVolume() const
	{
		//local only to this function
		double volume = myHeight * myWidth * myDepth;
		return volume;
	}
	
	// convert the obj to a string.
	string ToString() const; 
	
	// Mutators
	void boxHeight(double height=1.0)
	{
		if(height > 0.01)
		{
			setHeight(height);
		}else
		{
			throw std::invalid_argument("Height cannot be less than 0.01");
		}
	}	
	void boxWidth(double width=1.0)
	{
		setWidth(width);
	}	
	void boxDepth(double depth=1.0)
	{
		setDepth(depth);
	}
	
	//Changes box dimensions
	void setHeight(double height)
	{
		myHeight = height;
	}
	
	void setWidth(double width)
	{
		myWidth = width;
	}
	void setDepth(double depth)
	{
		myDepth = depth;	
	}

  private: 
	// Pivate data members for the state of the LightBulb
	double myHeight;
	double myWidth;
	double myDepth;
	
};

//Main
int main()
{
	//Declarations
	double height =1.0,width=1.0,depth=1.0,volume;
	int loop = 1;
	const double MIN_RANGE = 0.01;

	// parameterized constructor
	Box box1(height,width,depth);

	
	cout << "\t\t\t****************************************" 
		 << "\n\t\t\t********* Welcome to Box Class *********"
		 << "\n\t\t\t****************************************" << endl;
		
		do
		{
			
		cout << "\nEnter Height: ";	
		height = ConsoleInput::ReadDouble();
		if(height > MIN_RANGE)
		{
		
			box1.setHeight(height);	
				
			cout << "\nEnter Width: " ;	
			width  = ConsoleInput::ReadDouble();
		
			if(width > MIN_RANGE)
			{
				box1.setWidth(width);
	
				cout << "\nEnter Depth: " ;	
				depth = ConsoleInput::ReadDouble();
				if(depth > MIN_RANGE)
				{
					box1.setDepth(depth);
					loop = 0;	
				}
				else
				{
					cout<<"\n\nThe inputted depth must be greater than 0.01.\nPlease enter the box's dimensions again.\n";
				}
				
			}
			else
			{			
				cout<<"\n\nThe inputted width must be greater than 0.01.\nPlease enter the box's dimensions again.\n";
			}
		
		}
		else
		{
			cout<<"\n\nThe inputted height must be greater than 0.01.\nPlease enter the box's dimensions again.\n";
		}
			
		
		
		}while(loop = 1);
	
	
		
		//Display user enter input
		//cout << "\nYou entered Height as " << box1.ToString();
		 
		cout << "\nYou entered Height as " << box1.getHeight() << endl;
			 
		//cout << "You entered Width as " << box2.ToString()
		cout << "You entered width as " << box1.getWidth() << endl;
			 
		//cout << "You entered Depth as " << box3.ToString()
		cout << "You entered Depth as " << box1.getDepth() << endl;
		
		//Display the Volume
		cout << "\nVolume of the box: " << box1.getVolume() << endl;	
		
		cout << endl << endl;
		system("PAUSE");
		return 0;
}
