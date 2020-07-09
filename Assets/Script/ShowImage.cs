using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowImage : MonoBehaviour
{
    public GameObject image1;
    public GameObject image2;
    public GameObject image3;
    public GameObject image4;

    public GameObject title;

    void Start()
    {
        ShowEachImage();
    }
    public void ShowEachImage()
    {
        if((StaticScript.Image & 8) != 0) //1000
        {
            image1.SetActive(true);
        }
        if((StaticScript.Image & 4) != 0) //0100
        {
            image2.SetActive(true);
        }
        if((StaticScript.Image & 2) != 0) //0010
        {
            image3.SetActive(true);
        }
        if((StaticScript.Image & 1) != 0) //0001
        {
            image4.SetActive(true);
        }
        if(StaticScript.Image == 15)
        {
            title.SetActive(true);
        }
    }
}
