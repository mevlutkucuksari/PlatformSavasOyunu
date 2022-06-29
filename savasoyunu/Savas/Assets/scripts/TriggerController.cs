using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerController : MonoBehaviour
{
    public PlayerMovement player;

    
    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {

            player.onGround = true;
            Debug.Log("Trigger Oldu");
        }
    }
    
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        {

            player.onGround = false;
            Debug.Log("Trigger Olmadý.");
        }
    }
}
