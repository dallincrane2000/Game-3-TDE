using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exit : MonoBehaviour
{
    public GameObject doorClosed;
    public GameObject doorOpen;

    void Update()
    {
        if (GameObject.FindWithTag("Enemy") == false)
        {
            doorClosed.SetActive(false);
            doorOpen.SetActive(true);
        }
    }

}