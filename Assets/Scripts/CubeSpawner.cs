using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeSpawner : MonoBehaviour
{
    public GameObject cube;
    public GameObject trigger;
    public Transform cylinder;
    public float speed;
    public float spawnTime;
    public float timer;

    void Update()
    {
        timer -= Time.deltaTime;

        if(timer < 0)
        {
            SpawnCubes();
            timer = spawnTime;
        }
    }

    public void SpawnCubes()
    {
        int chance = 8;
        for(int i =-1; i<2; i++)
        {
            for(int j = -1; j<2; j++)
            {
                if(Random.Range(0, 9) < chance)
                {
                    GameObject c = Instantiate(cube, new Vector3(i, -10, j), Quaternion.identity);
                    c.transform.parent = cylinder;
                    chance -= 1;
                }
            }
        }
        GameObject t = Instantiate(trigger, new Vector3(0, -10, 0), Quaternion.identity);
        t.transform.parent = cylinder;
    }
}
