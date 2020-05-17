using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehaviour : MonoBehaviour
{

    public int score;
    public int multiplier = 1;
    public Rigidbody rb;

    void Update()
    {
        if(transform.position.y < -10)
        {
            transform.position = new Vector3(1, 7, -1);
            rb.velocity = Vector3.zero;
            score += 10;
            print("Si na konci, score :" + score);
        }
        if(transform.position.y > 10)
        {
            transform.position = new Vector3(1, 7, -1);
            rb.velocity = Vector3.zero;
            score = 0;
            print("Prehral si");
        }
    }

    void OnTriggerEnter(Collider c)
    {
        score += 10 * multiplier;
        print("Tvoje score: " + score);
        if(multiplier > 1)
        {
            print("super uzasny pad");
        }
        multiplier *= 2;
    }

    void OnCollisionEnter(Collision c)
    {
        multiplier = 1;
    }
}
