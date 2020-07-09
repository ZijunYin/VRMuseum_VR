using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroy : MonoBehaviour
{
    void Awake()
    {
        GameObject[] objs1 = GameObject.FindGameObjectsWithTag("Artwork1");
        GameObject[] objs2 = GameObject.FindGameObjectsWithTag("Artwork2");
        GameObject[] objs3 = GameObject.FindGameObjectsWithTag("Artwork3");
        GameObject[] objs4 = GameObject.FindGameObjectsWithTag("Artwork4");

        if (objs1.Length > 1)
        {
            Destroy(this.gameObject);
        }
        if (objs2.Length > 1)
        {
            Destroy(this.gameObject);
        }
        if (objs3.Length > 1)
        {
            Destroy(this.gameObject);
        }
        if (objs4.Length > 1)
        {
            Destroy(this.gameObject);
        }
        DontDestroyOnLoad(this.gameObject);
    }
}
