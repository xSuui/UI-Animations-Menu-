using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;
using DG.Tweening;
//using UnityEditor;

public static class Utill 
{
#if UNITY_EDITOR    
    [UnityEditor.MenuItem("Ebac/Test")]
    public static void Test()
    {
        Debug.Log("Test");
    }
    
    [UnityEditor.MenuItem("Ebac/Test2")]
    public static void Test2()
    {
        Debug.Log("Test2");
    }
    
    /*[UnityEditor.MenuItem("Ebac/Create GameObject %g")]
    public static void CreateGameObject()
    {
        GameObject newObject = new GameObject("MeuNovoGameObject"); // Crie um novo GameObject com um nome personalizado
                                                                    // Você pode adicionar mais personalizações ao novo GameObject aqui, se necessário
        Debug.Log("Novo GameObject criado: " + newObject.name);
    }*/

    [UnityEditor.MenuItem("Ebac/Create GameObject %g")]
    public static void CreateGameObject()
    {
        GameObject newObject = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        newObject.name = "MinhaNovaEsfera"; // Nome personalizado
                                            // Você pode adicionar mais personalizações ao novo GameObject aqui, se necessário
        Debug.Log("Nova esfera criada: " + newObject.name);
    }

#endif



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

    //public static Screens.ScreenBase GetRandom<Screens.ScreenBase>(this List<Screens.ScreenBase> list)
    public static T GetRandom<T>(this List<T> list)
    {
        return list[Random.Range(0, list.Count)];
    }
}
