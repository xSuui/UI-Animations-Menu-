using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;
using DG.Tweening;

public static class Utill 
{

    public static void Scale(this Transform t, float size = 1.2f)
        {
            t.localScale = Vector3.one * size;
        }
    
    
    public static void Scale(this GameObject t, float size = 1.2f)
        {
            t.transform.localScale = Vector3.one * size;
        }
    
    
    public static void ScaleVector(this Vector3 t, float size = 1.2f)
        {
            //t.localScale = Vector3.one * size;
        }
}
