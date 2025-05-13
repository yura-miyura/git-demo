// The function creates string, converts it to a char array then reverse all chars. 
// Funtion counts all the 'o' in  message, converts it back to a sting and then 
// prints out reversed string and amount of character 'o' in a message.
string str = "The quick brown fox jumps over the lazy dog.";

char[] charMessage = str.ToCharArray();

Array.Reverse(charMessage);

int x = 0;
foreach (char i in charMessage)
{ 
    if (i == 'o') { x++; } 

}

string new_message = new String(charMessage);

Console.WriteLine(new_message);
Console.WriteLine($"'o' appears {x} times.");