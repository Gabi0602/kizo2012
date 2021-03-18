 using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyFollow : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag=="bullet")
        {
            Debug.Log("yes");
            Invoke("Destroy1",0.1f);
            Destroy(other.gameObject);
        }
        else if (other.gameObject.tag == "Player")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }

    void Destroy1()
    {
        Destroy(gameObject);
    }
}
