using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AnswerPicker : MonoBehaviour
{
    [SerializeField]
    private Text answerText;

    [SerializeField]
    private Text catagoryText;

    private string answer = "Answer";

    private string[] danceAnswers = new string[] { "Macarena", "Cupid Shuffle", "Electric Slide", "Cotton Eye Joe", "The Worm", "Soulja Boy", "The Chicken Dance", "Twerking", "The Moon Walk", "Voguing", "The Twist", "Disco", "The YMCA", "Head Banging", "Thriller", "The Robot", "Gangnam Style", "What is Love", "Bye Bye Bye" };

    private string[] sportAnswers = new string[] { "Curling", "Baseball", "Soccer", "Tennis", "Ping-Pong", "Gymnastics", "Hockey", "Football", "Frisbee", "Basketball", "Swimming", "Powerlifting", "Archery", "Pole Vaulting", "Running", "Figure Skating", "Surfing", "Bowling", "Golf", "Volleyball", "Boxing", "Fencing" };

    public string GetRandomDanceAnswer()
    {
        return danceAnswers[Random.Range(0, danceAnswers.Length)];
    }

    public string GetRandomSportAnswer()
    {
        return sportAnswers[Random.Range(0, sportAnswers.Length)];
    }

    private void SetCurrentAnswer()
    {
        if (Random.value < 0.5f)
        {
            answer = GetRandomDanceAnswer();
            answerText.text = answer;
            catagoryText.text = "Dances";
        }
        else
        {
            answer = GetRandomSportAnswer();
            answerText.text = answer;
            catagoryText.text = "Sports";
        }
    }
}
