using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OBJECT : MonoBehaviour
{
    [SerializeField] private GameObject itemprefab;
    [SerializeField] private GameObject deadPlate;
    [SerializeField] private float speed = .5f;

    private float timer = 0;
    private bool jumped = false;

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if (timer > speed)
        {
            int randomnum = Random.Range(0, 10);

            GameObject iteminstance = Instantiate(itemprefab);

            if (randomnum % 4 == 0 && jumped)
            {
                GameObject deadplateinstance = Instantiate(deadPlate);

                iteminstance.transform.position = new Vector3(200, -25, 0);
                deadplateinstance.transform.position = new Vector3(200, -67.6f, 0);

                jumped = false;
            }

            else
            {
                iteminstance.transform.position = new Vector3(200, -40, 0);

                jumped = true;
            }

            timer = 0.0f;
        }
    }
}
