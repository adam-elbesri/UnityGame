using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public static float time;
    public static float horloge = 60;
    
    

    void Update()
    {
        if (time < horloge )GetComponent<Text>().text = ((int)(horloge - time)).ToString();
        time = Time.timeSinceLevelLoad;
    }
}
