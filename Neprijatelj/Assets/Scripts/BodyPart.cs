using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BodyPart : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;
    private Color start;
    private Color end;
    private float t;
    public Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        start = spriteRenderer.color;
        end = new Color(start.r, start.g, start.b, 0.0f);
    }

    // Update is called once per frame
    void Update()
    {
        t += Time.deltaTime;
        spriteRenderer.color = Color.Lerp(start, end, t / 2);
        if	(spriteRenderer.color.a <=0)
        {
            Destroy(gameObject);
        }
    }
}
