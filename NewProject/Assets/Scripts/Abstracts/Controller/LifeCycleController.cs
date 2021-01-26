using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class LifeCycleController : MonoBehaviour  //miras verdik
{
    [SerializeField] float maxlifetime = 5f;
    float _currentTime;
    private void Update()
    {
        _currentTime += Time.deltaTime; //zaman atadık
        if (_currentTime > maxlifetime)
        {
            Destroy(this.gameObject); //objemi yok et
        }

    }
}
