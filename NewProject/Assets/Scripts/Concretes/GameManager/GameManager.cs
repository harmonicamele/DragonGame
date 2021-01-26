using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] int score;
    public static GameManager Instance { get; private set; }  

    public event Action<int> OnscoreChangeg;   
    private void Awake()
    {
        SingeletonThisGameObject();
        
    }

    private void SingeletonThisGameObject()
    {
        if (Instance == null) 
        {
            Instance = this;
            DontDestroyOnLoad(this.gameObject);  
        }
        else
        {
            Destroy(this.gameObject);
        }
    }

    public void IncreaseScore()
    {
        score+=10;
        OnscoreChangeg?.Invoke(score); 
    }
    public void RestartGame()
    {
        Time.timeScale = 1f;
        StartCoroutine(RestArt()); 
    }
    private IEnumerator RestArt()
    {
        yield return SceneManager.LoadSceneAsync("Game");    
    }
    public void Exit()
    {
        Application.Quit();
    }
    public void ReturnMenu()
    {
        StartCoroutine(Return());
    }
    private IEnumerator Return()
    {
        yield return SceneManager.LoadSceneAsync("Menu");
    }
}

