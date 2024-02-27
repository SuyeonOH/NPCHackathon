using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


public class PLAYER : MonoBehaviour
{
    public static Action onChangedScore;
    public static PLAYER instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = new PLAYER();
            }

            return _instance;
        }
    }
    private static PLAYER _instance = null;

    public int score
    {
        get
        {
            return _score;
        }

        set
        {
            _score += value;
            onChangedScore?.Invoke();
        }
    }
    private int _score;

    private void Awake()
    {
        onChangedScore += show;
        _instance = this;
    }

    private void Start()
    {
        score = 0;
    }

    void show()
    {
        Debug.Log(this.score);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "GameOver")
        {
            Time.timeScale = 0;
        }
    }

}
