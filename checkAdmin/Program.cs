Console.WriteLine("Enter your role name (Administrator, Manager, or User)");
string? entry;
bool validString = false;

do
{
    entry = Console.ReadLine();
    validString = entry is not null && entry is "Administrator" or "User" or "Manager";
    Console.WriteLine(validString
        ? $"Your input value {entry} has been accepted."
        : $"The role name that you entered, {entry} is not valid. Enter your role name (Administrator, Manager, or User)");

} while (validString == false);