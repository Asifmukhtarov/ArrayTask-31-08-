/*Task 1

int[] arr = { 15, 34, 87, 46, 9, 21 };
int min = arr[0];
for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] < min)
    {
        min = arr[i];

    }
}
Console.WriteLine(min);


Task 2
string[] arr = { "salam", "necesiz", "kod", "Asif", "back-end" };
for (int i = 0; i < arr.Length; i++)
{
    if (arr[i].Length > 4)
    {
        Console.WriteLine(arr[i]);
    }
}



Task 3
int[] arr = { 4, 25, 13, 6, 7, 21 };
int count = 0;
for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] >= 0 && arr[i] < 10)
    {
        count++;
    }
}
Console.WriteLine("Reqemlerin sayi:" + count);



Task 4

string word = "Asif";
bool result = false;
for (int i = 0; i < word.Length; i++)
{
    if (word[i] == 'a' || word[i] == 'A')
    {
        result = true;
    }
}
if (result)
{
    Console.WriteLine("sozde a herfi var");

}
else
{
    Console.WriteLine("a herfi yoxdur");
}


Task 5

int[] arr = { 48, 5, -12, 14, 9, };

for (int i = 0; i < arr.Length - 1; i++)
{
    while (arr[i] > arr[i + 1])
    {
        int temp = arr[i];
        arr[i] = arr[i + 1];
        arr[i + 1] = temp;
        i = -1;
        break;
    }

}
for (int i = 0; i < arr.Length; i++)
{
    Console.WriteLine(arr[i]);

}
*/
