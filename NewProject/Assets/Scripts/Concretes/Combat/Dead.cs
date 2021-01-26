using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dead : MonoBehaviour
{
    public bool IsDead { get;private set; }  

    public event Action Ondead;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        IsDead = true;
        Time.timeScale = 0f; 
        Ondead?.Invoke();
    }
}
