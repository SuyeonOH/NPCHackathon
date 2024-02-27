using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DEAD : MonoBehaviour
{
    [SerializeField] private float speed = 70f;

    // Update is called once per frame
    void Update()
    {
        if (400 <= PLAYER.instance.score)
            speed = 110f;
        else if (300 <= PLAYER.instance.score)
            speed = 100f;
        else if (200 <= PLAYER.instance.score)
            speed = 90f;
        else if (100 <= PLAYER.instance.score)
            speed = 80f;
        transform.position += new Vector3(-1, 0, 0) * speed * Time.deltaTime;

        if (transform.position.x <= -177)
        {
            Destroy(gameObject);
        }
    }
}
