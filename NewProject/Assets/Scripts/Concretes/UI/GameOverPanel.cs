using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverPanel : MonoBehaviour
{
    public void yes()
    {
        GameManager.Instance.RestartGame(); 
    }
    public void no()
    {
        GameManager.Instance.ReturnMenu(); 
    }
}
