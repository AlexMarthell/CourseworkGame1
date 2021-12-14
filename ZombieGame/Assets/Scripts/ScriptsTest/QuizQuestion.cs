using UnityEditor;
using UnityEngine;

[CreateAssetMenuAttribute]
public class QuizQuestion : ScriptableObject
{
    [SerializeField]
    private string question;

    [SerializeField]
    private string[] answers;

    [SerializeField]
    private int correctAnswer;

    public string Question { get { return question; } }
    public string[] Answers { get { return answers; } }
    public int CorrectAnswer { get { return correctAnswer; } }

    public bool Asked { get; internal set; }

    private void OnValidate()
    {
        if (correctAnswer > answers.Length)
        {
            correctAnswer = 0;
        }
    }
}
