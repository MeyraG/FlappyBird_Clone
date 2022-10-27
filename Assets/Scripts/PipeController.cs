using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeController : MonoBehaviour
{
    public float speed;
    public Transform player;
   
    void Update()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;

        DestroyPipes();
    }

    private void DestroyPipes()
    {
        if (gameObject.transform.position.x < player.position.x)
        {
            Debug.Log("Destroy method works");
            Destroy(gameObject);
        }
    }
}