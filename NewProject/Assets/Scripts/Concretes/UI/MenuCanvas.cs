using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuCanvas : MonoBehaviour
{
   public void ExiButton()
    {
        GameManager.Instance.Exit();

    }
    public void StartButton()
    {
        GameManager.Instance.RestartGame();
    }
}
