using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleBehaviour : MonoBehaviour
{

    public float speed;

    void FixedUpdate()
    {
        transform.position += new Vector3(0, speed, 0);

        if(transform.position.y > 10)
        {
            Destroy(gameObject);
        }
    }
}
