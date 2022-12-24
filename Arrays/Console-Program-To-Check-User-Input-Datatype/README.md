# User Input's Datatype Validation in C# (Console App)

Create an application that takes 2 input values.

> 1.  Any input value (1st input)
> 2.  Asks the data type of the input value. (2nd input)

It will print to the console the options like below to take input for the 2nd input value:

> Press 1 for String
> Press 2 for integer
> Press 3 for Boolean
    

If the input value for the 2nd input is 1 then the application should check that if the entered 1st input is a valid string or not. Hereby we even want to check, if it is a complete alphabetic entry (so no numbers accepted)

If the input value for the 2nd input is 2 then the application should check if the entered 1st input is a valid integer or not.

Based on the input the 1st value and the selection of data type using the 2nd input, the application should return whether the entered 1st value is of data type selected by the user or not.

Please make sure to use a switch statement. To check the valid string you can write your custom logic.

_For example:_

_Enter a value: {here you can enter any value}_

_Select the Data type to validate the input you have entered._

_Press 1 for String_

_Press 2 for Integer_

_Press 3 for Boolean_

_Here, if you enter 1 it should return below message_

_You have entered a value: Denis Panjuta_

_It is a valid: String_

_Here, if you enter 2 it should return below message_

_You have entered a value: Denis Panjuta_

_It is an invalid: Integer_
