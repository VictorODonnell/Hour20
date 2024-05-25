using UnityEngine;
using TMPro;

public class Stopwatch : MonoBehaviour
{
    public TMP_Text timerText;
    private float startTime;
    private bool isRunning;

    void Start()
    {
        startTime = Time.time;
        isRunning = true;
    }

    void Update()
    {
        if (isRunning)
        {
            float t = Time.time - startTime;

            string minutes = ((int)t / 60).ToString("00");
            string seconds = (t % 60).ToString("00");
            string milliseconds = ((int)(t * 1000) % 1000).ToString("000");

            timerText.text = minutes + ":" + seconds + ":" + milliseconds;
        }
    }

    public void ToggleStopwatch()
    {
        isRunning = !isRunning;

        if (isRunning)
        {
            startTime = Time.time - (float.Parse(timerText.text.Substring(0, 2)) * 60 + float.Parse(timerText.text.Substring(3, 2)) + float.Parse(timerText.text.Substring(6, 3))) ;
        }
    }

    public void ResetStopwatch()
    {
        timerText.text = "00:00:000";
        startTime = Time.time;
    }
}
