using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//给GameObject扩展了一个方法    
public static class GameTools
{
    //给GameObject扩展了一个方法
    public static T GetOrAddComponent<T>(this GameObject go) where T : Behaviour
    {
        T ts = go.GetComponent<T>();
        if (ts == null)
        {
            ts = go.AddComponent<T>();
        }
        return ts;
    }
}
