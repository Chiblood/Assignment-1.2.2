/* Write a C# Sharp program to find the sum of first 10 natural numbers.
Expected Output :
The first 10 natural number is :
1 2 3 4 5 6 7 8 9 10
The Sum is : 55
*/
// Cheat solution
// using System.Linq;
// int[] myArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
// Console.WriteLine("The Sum is : " + myArray.Sum());

// Actual solution
int sum = 0;
for (int i = 1; i <= 10; i++) {
    sum += i;
}
Console.WriteLine("The Sum is : " + sum);