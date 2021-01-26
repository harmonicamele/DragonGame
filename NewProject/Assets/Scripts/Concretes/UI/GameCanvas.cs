using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameCanvas : MonoBehaviour
{
    [SerializeField] GameObject gameoverpanel;
    private void Awake()
    {
        Dead dead = FindObjectOfType<Dead>();
        dead.Ondead += HandleOnDead;
    }

    private void HandleOnDead()
    {
        gameoverpanel.SetActive(true);
     }
}
