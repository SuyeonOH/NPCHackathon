using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ITEM : MonoBehaviour
{

    [SerializeField] private float speed = 50f;
    private int score = 10;

    // Update is called once per frame
    void Update()
    {
        if (200 <= PLAYER.instance.score)
            speed = 90f;
        else if (150 <= PLAYER.instance.score)
            speed = 80f;
        else if (100 <= PLAYER.instance.score)
            speed = 70f;
        else if (50 <= PLAYER.instance.score)
            speed = 60f;

        transform.position += new Vector3(-1, 0, 0) * speed * Time.deltaTime;

        if (transform.position.x <= -177)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        PLAYER.instance.score = this.score;
        Destroy(gameObject);
    }
}
