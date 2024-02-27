using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class SCORE : MonoBehaviour
{
    [SerializeField] private TMP_Text scoreText;

    private void Awake()
    {
        PLAYER.onChangedScore += show;
    }

    // Start is called before the first frame update
    void Start()
    {
        scoreText.text = "Score : " + PLAYER.instance.score;
    }

    void show()
    {
        scoreText.text = "Score : " + PLAYER.instance.score;
    }
}
