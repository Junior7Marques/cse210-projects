using System;

public class Journal
{
    public List<Questions> _questions = new List<Questions>();
    public void Display()
    {
    
        foreach (Questions questions in _questions)
        {
            questions.Display();
        }
    }
}