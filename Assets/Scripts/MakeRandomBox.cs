using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakeRandomBox : MonoBehaviour
{
    public GameObject box;
    public Transform ResPawnPoint;
    public float timeToRespawn;
    public float timeToRespawnpoint;
    void Update()
    {
        if (Time.time> timeToRespawn)
        {
            SpawnBox();
            timeToRespawn =Time.time + timeToRespawnpoint;
        }
        
        
    }

    public void SpawnBox()
    {
        GameObject b = Instantiate(box, ResPawnPoint);
    }
}
