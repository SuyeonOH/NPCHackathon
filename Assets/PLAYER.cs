using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PLAYER : MonoBehaviour
{
    public int score;

    public static PLAYER Instance
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

    private void Awake()
    {
        _instance = this;
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        show();
    }

    void show()
    {
        Debug.Log(this.score);

    }
}
