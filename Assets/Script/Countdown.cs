using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Countdown : MonoBehaviour
{
    public GameObject text;
    public int TotalTime = 60;
    private int count;

    void Start ()
    {
        
    }

    public void StartCountdown(int totalTime)
    {
        count = totalTime;
        StartCoroutine(CountDown());
    }

    IEnumerator CountDown()
    {
        while (count >=0)
        {
            text.GetComponent<Text>().text = count.ToString() + "s";
            yield return new WaitForSeconds(1);
            count--;

        }
    }

}
