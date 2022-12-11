using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exit : MonoBehaviour
{
    public GameObject doorClosed;
    public GameObject doorOpen;

    public List<GameObject> enemies;

    void Update()
    {
        // iterates through all of the enemies and checks if they are "alive" if they are not they get removed from the list
        for (int i = 0; i < enemies.Count; i++)
        {
            if (!(enemies[i].activeInHierarchy))
            {
                enemies.RemoveAt(i);
            }
        }
        // checks if list is empty and it is empty the door opens
        if(enemies.Count == 0)
        {
            doorClosed.SetActive(false);
            doorOpen.SetActive(true);
        }

    }
}