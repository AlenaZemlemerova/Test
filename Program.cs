void Test()
{
    string[] words = {"hello", "2", "world",":-)"};
    PrintArray(words);
    int count = 0;
    Console.WriteLine("Слова не более 3х символов:");
    for (int i = 0; i < words.Length; i++)
    {  
        if (words[i].Length <= 3)
        {                        
            Console.Write(words[i] + " ");
            count++;                        
        }  
    }
    Console.WriteLine();
    Console.WriteLine("Количество слов не более 3х символов: " + count);
    
}

void PrintArray(string[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

Test();