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

    [SerializeField]
    private Button skipButton;

    [SerializeField]
    private Text scoreText;

    [SerializeField]
    private Text strikeText;

    [SerializeField]
    private Text timerText;

    [SerializeField]
    private float startingTime = 30.2f;

    private string answer = "Answer";
    private int numberOfStrikes = 0;
    private int score = 0;
    private float currentTime = 0.0f;

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

    private void Start()
    {
        SetCurrentAnswer();
        scoreText.text = "0";
        strikeText.text = "";

        SetTimer();
    }

    private void Update()
    {
        RunTimer();
    }

    private void SetTimer()
    {
        currentTime = startingTime;
    }

    private void RunTimer()
    {
        currentTime -= 1 * Time.deltaTime;
        timerText.text = currentTime.ToString("0.0");
    }

    public void SetCurrentAnswer()
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

        score++;
        scoreText.text = score.ToString();

        SetTimer();
    }

    public void Skip()
    {
        numberOfStrikes++;

        if (numberOfStrikes == 1)
        {
            strikeText.text = "X";
        }
        else if (numberOfStrikes == 2)
        {
            strikeText.text = "X X";
        }
        else if (numberOfStrikes == 3)
        {
            strikeText.text = "X X X";
            skipButton.enabled = false;
        }

        SetCurrentAnswer();
    }
}
