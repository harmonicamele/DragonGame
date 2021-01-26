using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DisplayScore : MonoBehaviour
{
    TextMeshProUGUI scoreText;
    private void Awake()
    {
        scoreText = GetComponent<TextMeshProUGUI>(); 
    }

    private void Start()
    {
        GameManager.Instance.OnscoreChangeg += HandleOnScorechg;
        HandleOnScorechg();
    }
    private void OnDisable()
    {
        GameManager.Instance.OnscoreChangeg -= HandleOnScorechg;
    }
    void HandleOnScorechg(int score=0)  
    {
        scoreText.text = $"Score:{score}";
    }
}
