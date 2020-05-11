using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{

    public GameObject obstacle;
    public Transform parent;
    public int speed;
    public float repeatTime;

    public float time;

    void Start()
    {
    }

    void Update()
    {
        time -= Time.deltaTime;

        if(time < 0)
        {
            time = repeatTime;

            for(int i = -1; i < 2; i++)
            {
                for(int j = -1; j < 2; j++)
                {
                    if(Random.Range(0,2) == 0)
                    {
                        GameObject obs = Instantiate(obstacle, new Vector3(i, -6, j), Quaternion.identity);
                        obs.transform.parent = parent;
                    }
                }
            }
        }
    }
}
