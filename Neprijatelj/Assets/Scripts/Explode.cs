using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explode : MonoBehaviour
{
    public BodyPart bodyPart;
    public int totalParts = 10;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Deadly")
        {
            OnExplode();
        }
    }

    private void OnExplode()
    {
        Destroy(gameObject);
        var t = transform;
        for (int i = 0; i < totalParts; i++)
        {
            BodyPart clone = Instantiate(bodyPart, t.position, Quaternion.identity) as BodyPart;
            clone.rb.AddForce(Vector3.right * Random.Range(-50, 50));
            clone.rb.AddForce(Vector3.up * Random.Range(100, 400));
        }
    }


}
