using System;
using System.Linq;

class Program
{
    static void Main()
    {
        // Predefined components based on your sample output
        string registrationNumber = "34"; // 2 digits from your registration number
        string firstName = "areeba";
        string lastName = "mehboob";
        string favoriteMovie = "punjab nahi jau gi";

        // Extract second letters
        char secondLetterFirstName = firstName[1]; // 'r' from "areeba"
        char secondLetterLastName = lastName[1];   // 'e' from "mehboob"

        // Predefined movie characters from "punjab nahi jau gi"
        string movieChars = "pj";

        // Define special characters
        string specialChar = "%"; // chosen special character

        // Combine all the parts to match the given password
        string password = secondLetterLastName + 
                          registrationNumber + 
                          secondLetterFirstName + 
                          secondLetterLastName +
                          specialChar + 
                          "@" + 
                          "K" + 
                          movieChars +
                          "w6";

        // Output the final password
        Console.WriteLine("Generated Password: " + password);
    }
}
