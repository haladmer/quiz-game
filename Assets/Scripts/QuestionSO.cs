using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(menuName = "Quiz Question",fileName = "New Question")]
public class QuestionSO : ScriptableObject
{
    [TextArea(2,6)]
    [SerializeField] string question = "Enter New Question Text";
    [SerializeField] string[] answer = new string[4];
    [SerializeField] int correctAnswer;

    public string GetQuestion()
    {
        return question;
    }
    public int GetCorrectAnswer()
    {
        return correctAnswer;
    }

    public string GetAnswer(int index)
    {
        return answer[index];
    }
}
