# PlingPlangPlong
The GetRaindropsString method inside Raindrop.cs takes an integer parameter and returns a string based on its factors. 

The method initialises an empty string, then concatenates it with "Pling" if the integer is divisible by 3, "Plang" if it is divisible by 5 and "Plong" if it is divisible by 7. If none of theses are factors of the integer, then it will return a string of the digits in the integer. 

GetRaindropsString also contains a condition to stop an integer of 0 returning "PlingPlangPlong". As 0 % n returns 0 for all values of n, for 0 this is explicity overridden to return the string "0". 

### Tests
The unit test project includes 2 unit tests. THese cover all possible outputs from the method, as well as all possible integer inputs. Non integer inputs are not considered as these are caught by the compiler prior to running, making testing unnecessary.  
