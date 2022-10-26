using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnController : MonoBehaviour
{
    public GameObject pipe;
    public float timeInterval;
    public float timer;
    void Start()
    {
        GameObject pipes = Instantiate(pipe);
        pipes.transform.position = transform.position + new Vector3(0, Random.Range(2, 5), 0);
    }

   
    void Update()
    {
        if (timer > timeInterval)
        {
            GameObject pipes = Instantiate(pipe);
            pipes.transform.position = transform.position + new Vector3(0, Random.Range(2, 5), 0);
            Destroy(pipes, 8);
            timer = 0;
        }

        timer += Time.deltaTime;
    }
}
