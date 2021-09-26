using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeManager : MonoBehaviour
{
    #region Singleton

    private static TimeManager _instance = null;

    public static TimeManager Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = FindObjectOfType<TimeManager>();

                if (_instance == null)
                {
                    Debug.LogError("Fatal Error: TimeManager not Found");
                }
            }

            return _instance;
        }
    }

    #endregion

    public int duration;

    private float time;

    void Start()
    {
        time = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (FlowManager.Instance.IsGameOver)
        {
            return;
        }

        if (time > duration)
        {
            FlowManager.Instance.GameOver();
            return;
        }

        time += Time.deltaTime;
    }
    public float GetRemainingTime()
    {
        return duration - time;
    }
}
