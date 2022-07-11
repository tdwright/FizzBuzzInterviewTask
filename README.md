# Solution Overview
The FizzBuzz test solution contains three projects:
1. FizzBuzzLib - where the business logic should be implemented, also contains interfaces
2. FizzBuzzLib.Tests - an XUnit project for the main library
3. FizzBuzzConsoleApp - Dotnet core console app

There are three interfaces defined:
1. `IFizzBuzz` is the main one, implemented by default. It specifies one method that takes an int and returns a string.
2. `IFizzBuzzRange` specifies a method that takes a start int and an end int, and returns an enumerable of strings.
3. `IFlexiFizzBuzz` specifies that there should be a dictionary of int and strings, for use in the extended version

## Main Task
The task is to implement the following requirements in a TDD manner:
1. Method `FizzBuzzifyAnInt` should return string representation of input integer
2. Where input is a multiple of 3, method should return "Fizz"
3. Where input is a multiple of 5, method should return "Buzz"
4. Where input is a multiple of 3 and 5 (e.g. 15), method should return "FizzBuzz"
5. Another method should take two integers, "start" and "end", iterate over the range, and return an enumerable of FizzBuzzed strings (implement `IFizzBuzzRange`)
6. The console app should print the FizzBuzz values for the numbers 0 to 100 (no XUnit test needed, just implement in console app)

The 2nd interviewer will work in a pair with the candidate, delivering the requirements and providing gently assistance as needed.

## Extended Task
For certain candidates, we may ask them to additionally implement the following:
1. FizzBuzz class to needs implement `IFlexiFizzBuzz`, with the dictionary defaulting to `{ {3, "Fizz"}, {5, "Buzz"} }`
2. Method `FizzBuzzifyAnInt` needs to be modified to use the dictionary - for each dictionary key that the input is a multiple of, return value should include the corresponding string value.

Test cases (1-10):
* Dictionary contains FizzBuzz values. Sequence should be as expected.
* Dictionary contains `{ {2, "Even"} }`. Sequence should be 1, Even, 3, Even, 5, Even, 7, Even, 9, Even
* Dictionary contains `{ {2, "Quack"}, {5, "Honk"} }`. Sequence should be 1, Quack, 3, Quack, Honk, Quack, 7, Quack, 9, QuackHonk