using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ITEM : MonoBehaviour
{
    private int score = 1;
    [SerializeField] private float speed = 7f;
    PLAYER player = new PLAYER();



    private void Update()
    {
        transform.position += new Vector3(-1, 0, 0) * speed * Time.deltaTime;

        if (transform.position.x <= -10)
        {
            Destroy(gameObject);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        PLAYER.Instance.score += this.score;
        Destroy(gameObject);

    }

}