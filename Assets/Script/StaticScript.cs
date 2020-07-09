using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public static class StaticScript
{
    private static int image = 0;

    public static int Image 
    {
        get 
        {
            return image;
        }
        set 
        {
            image = value;
        }
    }

}

