using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BaseSpawner : MonoBehaviour   
{
    [Range(2f, 5F)]
    [SerializeField] float maxspawntime = 3f;
    [Range(0.3f, 1.5f)]
    [SerializeField] float minspawntime = 1f;

    

    float currentSpawntime;
    float timeboundry; 


    private void Start()
    {
        ResetTime();
    }
    private void Update()
    {
        currentSpawntime += Time.deltaTime;
        if (currentSpawntime > timeboundry)
        {
            Spawn();
            ResetTime();
        }
    }

    

    protected abstract void Spawn(); 
    

    private void ResetTime()
    {
        currentSpawntime = 0f;
        timeboundry = Random.Range(minspawntime, maxspawntime);
    }

}
