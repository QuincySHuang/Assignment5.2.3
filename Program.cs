
Console.WriteLine("Enter word to check if palindrome");
string input = Console.ReadLine();

input = input.ToLower();

if (Palindrome(input,0, input.Length - 1))
{
    Console.WriteLine($"{input } is palindrome");
}
else
{
    Console.WriteLine($"{input} is not a palindrome");
}


bool Palindrome(string s, int beginning, int end)
{
    if(beginning >= end)
    {
        return true;
    }
    if (s[beginning] != s[end])
    {
        return false;
    }

    return Palindrome(s, beginning + 1, end - 1);

}