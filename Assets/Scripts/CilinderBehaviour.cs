using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CilinderBehaviour : MonoBehaviour
{
    public float speed;

    // Update is called once per frame
    void Update()
    {
        float rot = Input.GetAxis("Horizontal");
        transform.Rotate(new Vector3(0, rot, 0) * speed);
    }
}
