using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyerPipes : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Pipe"))
        {
            Debug.Log("Pipes are going");
            Destroy(collision.gameObject);
        }
    }
}
