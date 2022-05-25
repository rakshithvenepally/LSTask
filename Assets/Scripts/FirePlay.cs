using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class FirePlay : MonoBehaviour
{
    public ParticleSystem P1;

    public void StartFire()
    {
        P1.Play();

    }
        
}
