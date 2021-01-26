using NewProject.Controller;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedDragonSpawner : BaseSpawner 
{
    [SerializeField] EnemyController enemy;

    protected override void Spawn()
    {
        Instantiate(enemy, this.transform);
    }
}
