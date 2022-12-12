using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnDivineSoul : MonoBehaviour
{
    public GameObject soul;

    // Update is called once per frame
    void Update()
    {
        if(GameObject.FindWithTag("Enemy") == false)
        {
            Instantiate(soul, gameObject.transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
    }
}
