using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlowManager : MonoBehaviour
{
    #region Singleton

    private static FlowManager _instance = null;

    public static FlowManager Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = FindObjectOfType<FlowManager>();

                if (_instance == null)
                {
                    Debug.LogError("Fatal Error: GameFlowManager not Found");
                }
            }

            return _instance;
        }
    }

    #endregion

    public bool IsGameOver { get { return isGameOver; } }

    private bool isGameOver = false;


    [Header("UI")]
    public UIGameOver GameOverUI;

    void Start()
    {
        isGameOver = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GameOver()
    {
        isGameOver = true;
        ScoreManager.Instance.SetHighScore();
        GameOverUI.Show();
    }
}
