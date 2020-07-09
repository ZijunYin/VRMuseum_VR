using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowMC : MonoBehaviour
{
    public GameObject countdownText;
    public GameObject ExtraText;
    public GameObject ExtraInstruction;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(countdownText.GetComponent<Text>().text.Equals("0s"))
        {
            ExtraInstruction.SetActive(false);
            ExtraText.SetActive(false);
            
        }
        else
        {
            ExtraInstruction.SetActive(true);
            ExtraText.GetComponent<Text>().text = countdownText.GetComponent<Text>().text;
            ExtraText.SetActive(true);
            
        }        
    }

}
