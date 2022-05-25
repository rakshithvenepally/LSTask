using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pulse : MonoBehaviour
{
    
    public float max;
    public float min;
    public Vector3 scale;



    void Update()
    {
        for(int i = 0; i < 3; i++)
        {
            scale[i] = max + min * Mathf.Sin(Time.time);
            transform.localScale = scale;
        }

    }


}

