using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;
using System;

public class CorrectAnswer : MonoBehaviour
{
    public ToggleGroup toggleGroupInstance;
    public GameObject correctCanvas;
    public GameObject wrongCanvas;
    public GameObject imageCanvas;
    public int QuestionNumber;
    public string CorrectChoice;
    public GameObject countdownText;
    public GameObject ExtraText;
    public GameObject ExtraInstruction;
    public int TotalTime = 60;
    private int count;
    GameObject activeObj;
    GameObject[] objs1; 
    GameObject[] objs2; 
    GameObject[] objs3; 
    GameObject[] objs4; 

    // Start is called before the first frame update
    void Start()
    {

    }
    void Update()
    {
        switch(QuestionNumber)
        {
            case 8: objs1 = GameObject.FindGameObjectsWithTag("Artwork1");
                    activeObj = objs1[0];
                    break;
            case 4: objs2 = GameObject.FindGameObjectsWithTag("Artwork2");
                    activeObj = objs2[0];
                    break;
            case 2: objs3 = GameObject.FindGameObjectsWithTag("Artwork3");
                    activeObj = objs3[0];
                    break;
            case 1: objs4 = GameObject.FindGameObjectsWithTag("Artwork4");
                    activeObj = objs4[0];
                    break;
            default:
                    break;
        }

        countdownText.GetComponent<Text>().text = 
            activeObj.GetComponent<CountdownInt>().count.ToString() + "s";    
        
        if(activeObj.GetComponent<CountdownInt>().count <= 0)
        {
            ExtraInstruction.SetActive(false);
            ExtraText.SetActive(false);
        }
        else
        {
            ExtraInstruction.SetActive(true);
            ExtraText.SetActive(true);
            ExtraText.GetComponent<Text>().text = 
                activeObj.GetComponent<CountdownInt>().count.ToString() + "s";
        }  
    }
    public void CheckAnswer()
    {
        if(activeObj.GetComponent<CountdownInt>().count <= 0)
        {
            var toggle = toggleGroupInstance.ActiveToggles().FirstOrDefault();
            if(toggle.name.Equals(CorrectChoice))
            {
                correctCanvas.SetActive(true);
                if((StaticScript.Image & QuestionNumber) == 0)
                {
                    StaticScript.Image += QuestionNumber; //1000
                }
                imageCanvas.GetComponent<ShowImage>().ShowEachImage();
            }
            else
            {
                wrongCanvas.SetActive(true);
                count = TotalTime;
                activeObj.GetComponent<CountdownInt>().StartCountdown(60);
            }
        }
        else
        {        
            wrongCanvas.SetActive(true);
        }

    }

}
