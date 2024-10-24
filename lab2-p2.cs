using System;

bool doorLocked = true;
int userAttempts = 0;
do
{
    userAttempts++;
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
while (userAttempts < 5);
	}
}
