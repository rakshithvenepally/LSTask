using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotObj : MonoBehaviour
{

    void Start()
    {

    }


    void Update()
    {
        if (Input.GetMouseButton(0) == true)
        {
            StartCoroutine(Rotate());
        }
    }


    IEnumerator Rotate()
    {

        transform.Rotate(new Vector3(0f, Time.time, Time.time));
        yield return null;
    }
}
