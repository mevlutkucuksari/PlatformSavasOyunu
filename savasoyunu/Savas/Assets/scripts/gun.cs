using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gun : MonoBehaviour   
{
    
    private void OnCollisionEnter2D(Collision2D collision) 
    {
        if (collision.gameObject.tag=="enemy") 
        {
            Destroy(collision.gameObject); 
        }
    }
}
