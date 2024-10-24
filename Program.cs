while (true)
{
    Console.WriteLine("Hello, World!");

    Console.WriteLine("Would you like me to continue? (yes/no)");
    String userProceedResponse = Console.ReadLine();

    if (userProceedResponse.ToLower() != "yes")
    {
        break;
            }
}

Console.WriteLine("Please enter a number:");
int userNumberChoice = int.Parse(Console.ReadLine());

for(int i = userNumberChoice; i >= 0; i--)
{
    Console.WriteLine(i);
}
for(int i = 0; i <= userNumberChoice; i++)
{
    Console.WriteLine(i);
}



bool doorLocked = true;
int userAttempts = 0;
for (int i = userAttempts; i < 5; i++)
{
    i = i++;
    Console.WriteLine("Please enter the 5 digit pincode:");
    int userPincodeResponse = int.Parse(Console.ReadLine());
    if (userPincodeResponse != 13579)
    {
        Console.WriteLine("Incorrect Pincode Input!");
    }
    else if (userPincodeResponse == 13579)
    {
        Console.WriteLine("Welcome!");
        doorLocked = false;
        break;
    }
}