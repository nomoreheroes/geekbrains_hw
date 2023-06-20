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

int counter = 0;
Console.WriteLine("Let me find the number of not long enough and evil spells...");
for(int i=0;i<N;i++)
    if (InitArr[i].Length <= 3) counter++;
Console.WriteLine($"Oh, there are only {counter}...");
Console.WriteLine("Well, let's make a pitiful list of them");

string[] FinalArr = new string[counter];
int j=0;
for(int i=0;i<N;i++)
{
    if(InitArr[i].Length<=3) FinalArr[j++] = InitArr[i];
}

Console.WriteLine($"Here they are, insignificant creatures: {ShowArray(FinalArr)}");


