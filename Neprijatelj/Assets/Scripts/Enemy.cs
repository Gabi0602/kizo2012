using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public Transform player;
    public Rigidbody2D rb;
    private Vector2 movement;
    public float moveSpeed = 5f;
    public Transform[] waypoints;
    public int waypointIndex = 0;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player").transform;
        this.transform.position = GameObject.Find("WayPoint").transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 direction = player.position - this.transform.position;
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        rb.rotation = angle;
        direction.Normalize();
        movement = direction;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Bullet")
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
    }

    private void FixedUpdate()
    {
        Move(movement);

        if (waypointIndex <= waypoints.Length - 1)
        {
            Vector2 newPosition = Vector2.MoveTowards(transform.position, waypoints[waypointIndex].transform.position, moveSpeed);
            rb.MovePosition(newPosition);

            if (transform.position == waypoints[waypointIndex].transform.position)
            {
                waypointIndex += 1;

                if (waypointIndex < waypoints.Length)
                {
                    Vector3 direction = waypoints[waypointIndex].transform.position - this.transform.position;
                    float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
                    rb.rotation = angle;
                }
            }
        }
    }

    private void Move(Vector2 direction)
    {
        rb.MovePosition((Vector2)rb.position + (direction * moveSpeed));
    }
}
