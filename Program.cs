void Test()
{
    string[] words = {"hello", "2", "world",":-)"};
    Console.WriteLine("Начальный массив: ");
    PrintArray(words);
    int count = 0;
    for (int i = 0; i < words.Length; i++)
    {  
        if (words[i].Length <= 3)
        {                        
            count++;                        
        }  
    }
    Console.WriteLine("Количество слов не более 3х символов: " + count);

    string[] finalArray = new string [count];
    int index = 0;
    for (int i = 0; i < words.Length; i++)
    {  
        if (words[i].Length <= 3)
        {                      
            finalArray[index] = words[i];
            index++;                                   
        }  
    }
    Console.WriteLine("Итоговый массив: ");
    PrintArray(finalArray);    
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