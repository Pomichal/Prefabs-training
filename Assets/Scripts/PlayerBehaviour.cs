using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehaviour : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if(transform.position.y <= -6)
        {
            transform.position = new Vector3(-1, 4, -1);
        }

    }
}
