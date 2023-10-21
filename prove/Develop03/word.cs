using System;
using System.ComponentModel;
using System.Dynamic;
public class Word 
{
   
    private string[] _modifiedVerse;
    private int index;
    
    private int count;

    public string[] ModifiedVerse(string _verse)
    {
        Random randomGenerator = new Random();
        
        
        int runCount = 0;
        if (count != 0)
        {
            do 
            {
                index = randomGenerator.Next(0,_modifiedVerse.Length);
                
                if (_modifiedVerse[index].Contains("1") | _modifiedVerse[index].Contains("2") | _modifiedVerse[index].Contains("3") |_modifiedVerse[index].Contains("4") | _modifiedVerse[index].Contains("5") | _modifiedVerse[index].Contains("6") | _modifiedVerse[index].Contains("7") |_modifiedVerse[index].Contains("8") | _modifiedVerse[index].Contains("9") |_modifiedVerse[index].Contains("_ _ _")) 
                {
                    _modifiedVerse[index] = _modifiedVerse[index];
                }
                else if (_modifiedVerse[index].Contains(","))
                {
                    _modifiedVerse[index] = "_ _ _,";
                    runCount++;
                }
                else if (_modifiedVerse[index].Contains("."))
                {
                    _modifiedVerse[index] = "_ _ _.";
                    runCount++;
                }
                else if (_modifiedVerse[index].Contains("?"))
                {
                    _modifiedVerse[index] = "_ _ _?";
                    runCount++;
                }
                else if (_modifiedVerse[index].Contains("!"))
                {
                    _modifiedVerse[index] = "_ _ _!";
                    runCount++;
                }
                else if (_modifiedVerse[index].Contains(";"))
                {
                    _modifiedVerse[index] = "_ _ _;";
                    runCount++;
                }
                else
                {
                    _modifiedVerse[index] = "_ _ _";
                    runCount++;
                }
            }
            while (runCount++ < 4);
            
        }
        else {
            _modifiedVerse = _verse.Split(" ");
        }
        count++;
        return _modifiedVerse;
    }
}