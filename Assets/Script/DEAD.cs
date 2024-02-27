using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DEAD : MonoBehaviour
{
    [SerializeField] private float speed = 7f;

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(-1, 0, 0) * speed * Time.deltaTime;

        if (transform.position.x <= -177)
        {
            Destroy(gameObject);
        }
    }
}
