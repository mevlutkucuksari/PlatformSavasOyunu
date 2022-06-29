using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public Transform Player; 
    void Update()
    {
        transform.position = new Vector3(Mathf.Clamp(Player.position.x, -128f, 86f), transform.position.y, transform.position.z);
        
        if (transform.position.x<=-4)
        {
            
           transform.position = new Vector3(-4, 0,-10);
        }
        if (transform.position.x >= 29.87f)
        {
            
            transform.position = new Vector3(29.87f, 0,-10);
        }
    }
}
