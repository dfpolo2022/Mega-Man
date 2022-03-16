using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleDestroy : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "instakill") { 
        Destroy(collision.gameObject);
        }
        
    }
}