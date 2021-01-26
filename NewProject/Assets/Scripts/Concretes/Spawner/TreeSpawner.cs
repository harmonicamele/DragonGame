using NewProject.Controller;
using NewProject.Movements;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace NewProject.Spawner
{
    public class TreeSpawner : BaseSpawner
    {


        [SerializeField] EnemyController[] enemies;



        protected override void Spawn()
        {
            int enemyIndex = Random.Range(0, enemies.Length);   
            Instantiate(enemies[enemyIndex], this.transform);

        }

    }
}
        
       


