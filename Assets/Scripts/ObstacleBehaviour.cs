using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleBehaviour : MonoBehaviour
{

    public float speedUp;

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.up * speedUp;

        if(transform.position.y > 10)
        {
            Destroy(gameObject);
        }
    }
}
