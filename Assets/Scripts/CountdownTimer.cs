using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountdownTimer : MonoBehaviour
{

    float currentTime = 0f;
    float startingTime = 3f;

    public Text countdownText;

    public string countString;

    void Start()
    {
        currentTime = startingTime;

    }

    void Update()
    {
        currentTime -= 1 * Time.deltaTime;
        countdownText.text = currentTime.ToString("0");

        countString = countdownText.text;

        if (currentTime <= 0)
        {
            countdownText.text = " ";

        }

        
        
    }

    /*public int countdownTime;
    public Text countdownDisplay;   

    private void Start()
    {
        StartCoroutine(CountdownToStart());
    }

    IEnumerator CountdownToStart()
    {
        while (countdownTime > 0)
        {
            countdownDisplay.text = countdownTime.ToString();
            yield return new WaitForSeconds(1f);
            countdownTime--;
        }

        countdownDisplay.text = "Go";
        GameController.instance.BeginGame();
        yield return new WaitForSeconds(1f);
        countdownDisplay.gameObject.SetActive(false);
    }*/
}
