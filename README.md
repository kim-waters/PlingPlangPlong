# PlingPlangPlong
The GetRaindropsString method inside Raindrop.cs takes an integer parameter and returns a string based on its factors. 

The method initialises an empty string, then concatenates it with "Pling" if the integer is divisible by 3, "Plang" if it is divisible by 5 and "Plong" if it is divisible by 7. If none of theses are factors of the integer, then it will return a string of the digits in the integer.

This is a console application that is run in the RainDropsApp project. The console prompts the user for input, and will call the method if an integer is successfully parsed from the input.

### Tests
The unit test project includes 2 unit tests. These cover all possible outputs from the method, as well as all possible integer inputs. Non integer inputs are not considered as these are caught by the compiler prior to running, making testing unnecessary.  
