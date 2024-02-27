using UnityEngine;

public class BGScroller : MonoBehaviour
{
    private Renderer render;
    public float speed = 0.3f;
    private float offset;

    void Start()
    {
        render = GetComponent<Renderer>();
    }

    void Update()
    {
        if (200 <= PLAYER.instance.score)
            speed = 1.1f;
        else if (150 <= PLAYER.instance.score)
            speed = 0.9f;
        else if (100 <= PLAYER.instance.score)
            speed = 0.7f;
        else if (50 <= PLAYER.instance.score)
            speed = 0.5f;
        offset += Time.deltaTime * speed;
        render.material.mainTextureOffset = new Vector2(offset, 0);
    }
}