using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float health = 10;
    public Material matWhite;
    public Material matDefault;
    public SpriteRenderer sr;
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Tu sam");
        if (collision.CompareTag("Bullet"))
        {
            Debug.Log("Tu sam2");
            health -= collision.gameObject.GetComponent<Bullet>().damage;
            Destroy(collision.gameObject);
            if (health <= 0)
            {
                KillSelf();
            }
        }
    }

    private void KillSelf()
    {
        Destroy(gameObject);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
