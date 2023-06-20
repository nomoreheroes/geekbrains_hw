Console.WriteLine("I'm begging, master, tell me, what size would you like the initial array to be");
int N = Convert.ToInt32(Console.ReadLine());

String ShowArray(string[] arr)
{
    return $"[{string.Join(',',arr)}]";
}

string[] InitArr = new string[N];
Console.WriteLine("The array created to your glory, we just need to fill it");
for(int i=0;i<N;i++)
{
    Console.WriteLine($"I'm on my knees, please, enter the {i+1} string!");
    InitArr[i] = Console.ReadLine();
}
Console.WriteLine("My lord, now we are ready to do our dark and terrible deeds");
Console.WriteLine($"HERE IS IT: {ShowArray(InitArr)}");

