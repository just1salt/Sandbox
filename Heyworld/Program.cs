Console.WriteLine("Hey, World!");
// Console.WriteLine("Enter a positive integer");

// //This is a string variable named "input"
// string input = Console.ReadLine();

// //We are taking whatever the user inputs and printing it back out to the console. 
// Console.WriteLine("You entered " + input);

// //We are parsing the string (input) variable and converting it into a number so we can do a arithmetic on it.
// int number = int.Parse(input);
// //Console.WriteLine("We parsed your input to " + number);

// // while Loop  
// while (number <= 0)   //If user inputs a number less than or equal to 0 it will write one of the lines below. (This may execute 0 or more times).                     
// {
//     Console.WriteLine("The number should be greater than 0");
//     Console.WriteLine("Enter a positive number");
//     input = Console.ReadLine();
//     number = int.Parse(input);
// }


string input = "";  //Initialize my string variable named "input" and have it equal an empty string.
int number = 0;     //Initialize my integer variable named "number" and set it to equal 0.
//Do While Loop (This will execute at least 1 or more times)
do  //do while loop
{
    Console.WriteLine("Enter a positive number");
    input = Console.ReadLine();
    number = int.Parse(input);

    if(number <= 0)
    {
        Console.WriteLine("The number should be greater than 0");
    }
} while(number <= 0);

// This will count up to the number the user inputs and print them to the console using a "while loop".
// For ex. If user inputs 10, the console will display 1, 2, 3, 4, 5, 6, 7, 8, 9, 10.
// int counter = 1;

// while(counter <= number)
// {
//     Console.WriteLine(counter);
//     counter++;
// }

// Another way of counting up to the number using a "for loop". 
for(int i = 1; i <= number; i++)
{
    if(i % 15 == 0)                //This is considered a "else if" block. 
    {
        Console.WriteLine("HeyWorld");
    }
    else if (i % 3 == 0)
    {
        Console.WriteLine("Hey");
    }
    else if (i % 5 == 0)
    {
        Console.WriteLine("World");
    }
    else 
    {
        Console.WriteLine(i);
    }
}
