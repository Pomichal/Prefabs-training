using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CylinderBehaviour : MonoBehaviour
{

    public float speed;
    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        transform.Rotate(new Vector3(0, -horizontal, 0) * speed);
    }
}
