/** Lab7_Group7.h
 *
 *    A re-usable library of input validation functions.
 *
 *    @author   Ali Hassan Mahdi
 *    @author   Chilka Patel
 *    @author   Seyed Ifham Buhary
 *    @version  2019.08
 *    @since    3 August 2019
 */


#ifndef Lab7_Group7_h
#define Lab7_Group7_h


#include "Lab7_Group7.cpp"

namespace Lab7
{
    /**    IsNumeric function
     * Checks the input entered by user to see it's numeric
     *
     * @param  value the input entered by the user
     * @return boolean value indicating if the input is numeric and double.
     */
    bool IsNumeric(std::string value);
    
    /**    ReadDouble function
     * Reads a valid double value from the console with range checking
     *
     * @param  MIN the minimum value the user may enter; defaults to the minimum int.
     * @param  MIN the minimum value the user may enter; defaults to the maximum int.
     * @return A validated double input by the user.
     */
    double ReadDouble(const int MIN = INT_MIN, const int MAX = INT_MAX);

}

#endif /* Lab7_Group7_h */

