using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipeSpawner : MonoBehaviour
{
    public GameObject Pipe;
    public float spawnRate = 2;
    public float timer;
    public float spawnHeight = 10;
    // Start is called before the first frame update
    void Start()
    {
        spawn();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnRate)
        {
            timer += Time.deltaTime;
        }
        else
        {
            spawn();
            timer = 0;
        }
       
    }
    void spawn()
    {
        float lowestPoint = transform.position.y - spawnHeight;
        float highestPoint = transform.position.y + spawnHeight;
        Instantiate(Pipe, new Vector3(transform.position.x, Random.Range(highestPoint, lowestPoint),0), transform.rotation);
    }
}
