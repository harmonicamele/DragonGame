using NewProject.Controller;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireballController : LifeCycleController
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        EnemyController enemy = collision.GetComponent<EnemyController>();
        if (enemy!=null)  

        {
            GameManager.Instance.IncreaseScore();
            Destroy(enemy.gameObject);
            Destroy(this.gameObject);
        }
    }
}
