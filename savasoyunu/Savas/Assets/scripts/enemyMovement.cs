using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyMovement : MonoBehaviour
{
    bool isGround;
    float width;
    Rigidbody2D rb;
    public LayerMask layer;
    public float enemyHiz;
    Animator anim;
    public GameObject olmePaneli;
    PlayerMovement player;
    public AudioClip characterDie;
    public AudioSource seskaynak;
    void Start()
    {
        width = GetComponent<SpriteRenderer>().bounds.extents.x;
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        player = GetComponent<PlayerMovement>();
        
    }
    
    void Update()
    {
        RaycastHit2D hit = Physics2D.Raycast(transform.position+(transform.right*width/2), Vector2.down, 1f);

        if (hit.collider!=null)
        {
            isGround = true;
        }
        else
        {
            isGround = false;
        }
        if (!isGround)
        {
            transform.eulerAngles += new Vector3(0, 180f, 0);
        }



        rb.velocity = new Vector2(transform.right.x * enemyHiz, 0f);

    }
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.blue;
        Gizmos.DrawLine(transform.position + (transform.right * width / 2), transform.position + (transform.right * width / 2) + new Vector3(0, -1f, 0));
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag=="Player")
        {
            Destroy(collision.gameObject,0.5f);
            anim.SetBool("enemyAttack", true);
            olmePaneli.SetActive(true);
            seskaynak.PlayOneShot(characterDie);


        }
    }
}
