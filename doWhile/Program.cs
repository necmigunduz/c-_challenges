Random random = new Random();
// int current = 0;

// do
// {
//     current = random.Next(1, 10);
//     Console.WriteLine(current);
// } 
// int current = 3;
// int sum = 0;
// while (current >= 3)
// {
//     current = random.Next(1, 11);
//     Console.WriteLine(current);
//     sum += current;
// }
// Console.WriteLine($"Last number: {current} and sum is {sum}.");
// int current = random.Next(1,11);

// do {
//     current = random.Next(1,11);
//     if (current >= 8) continue;
//     Console.WriteLine(current);
// } while (current != 7);

// int hero = 10;
// int monster = 10;

// Random dice = new Random();

// do
// {
//     int roll = dice.Next(1, 11);
//     monster -= roll;
//     Console.WriteLine($"Monster was damaged and lost {roll} health and now has {monster} health.");

//     if (monster <= 0) continue;

//     roll = dice.Next(1, 11);
//     hero -= roll;
//     Console.WriteLine($"Hero was damaged and lost {roll} health and now has {hero} health.");

// } while (hero > 0 && monster > 0);

// Console.WriteLine(hero > monster ? "Hero wins!" : "Monster wins!");

// string? readResult;

// bool validEntry = false;
// Console.WriteLine("Enter a string containing at least three characters!");

// do 
// {
//     readResult = Console.ReadLine();
//     if (readResult != null) {
//         if (readResult.Length >= 3) {
//             validEntry = true;
//         } else {
//             validEntry = false;
//         }
//     }

//     string result = validEntry == true ? "You have entered a string containing at least three characters!" : "Try again!";
//     Console.WriteLine(result);
// } while (validEntry == false);

// int numericValue = 0;
// bool validNumber = false;

// validNumber = int.TryParse(readResult, out numericValue);

// Console.WriteLine($"Is it a valid number? {validNumber}.");
// string res = validNumber == true ? $"The numeric number is {numericValue}." : "It is not a numeric value!";
// Console.WriteLine(res);

string? readResult;
bool validEntry = false;
int numericValue = 0;
bool validNumeric = false;
Console.WriteLine("Enter a numeric value between 5 and 10 exclusively.");

do
{
    readResult = Console.ReadLine();
    if (readResult is not null)
    {
        validNumeric = int.TryParse(readResult, out numericValue);
        if (validNumeric)
        {
            bool res = int.Parse(readResult) is < 10 and > 5;
            Console.WriteLine(res == true
                ? $"You entered {readResult} and it is between 5 and 10."
                : $"You entered {readResult}. Please enter a number between 5 and 10.");
            validEntry = res ? true : false; 
        }
        else
        {
            Console.WriteLine($"{readResult} is not numeric! Please enter a numeric value!");
        }
    }

} while (validEntry == false);

Console.WriteLine($"Your input value ({readResult}) has been accepted.");