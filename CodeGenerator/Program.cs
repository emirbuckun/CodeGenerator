// Declare constants 
const string AllowedChars = "ACDEFGHKLMNPRTXYZ234579";
const int Length = 8;
Random random = new();

// For loop for generating 1000 code examples
for (int i = 0; i < 1000; i++)
{
  char[] code = new char[Length];

  // Get random chars from our allowed chars and put it into code
  for (int j = 0; j < Length; j++)
    code[j] = AllowedChars[random.Next(0, AllowedChars.Length)];

  Console.WriteLine(code);
}
