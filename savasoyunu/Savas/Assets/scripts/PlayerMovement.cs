using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
public class PlayerMovement : MonoBehaviour
{
    
    public float hiz;
    public float ziplamaHiz; 
    private Rigidbody2D rb;
    private float hizX; 
    private Vector3 yon; 
    private Animator anim;
    private bool gun;
    public bool onGround; 
    public float ataksuresi; 
    public float ataksuresibelirleme; 
    public GameObject shoot;
    public TextMeshProUGUI scoreText;
    float score;
    public GameObject deadPanel; 
    public GameObject winPanel;
    public AudioClip characterDie;
    public AudioClip gunSound;
    public AudioSource seskaynak;



    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        yon = transform.localScale; 
        anim = GetComponent<Animator>();
        gun = false;

    }

    void Update()
    {
        
        hizX = Input.GetAxis("Horizontal"); 
        rb.velocity = new Vector2(hizX * hiz, rb.velocity.y);
        anim.SetFloat("Speed", Mathf.Abs(hizX));
        

        if (hizX > 0)
        {
            transform.localScale = new Vector3(yon.x, yon.y, yon.z); 
        }
        if (hizX < 0)
        {
            transform.localScale = new Vector3(-yon.x, yon.y, yon.z); 
        }

        if (Input.GetKeyDown(KeyCode.Space)&& onGround==true) 
        {
            if (onGround && Input.GetKeyDown(KeyCode.Space))
            {
                anim.SetTrigger("jump"); 
                rb.velocity = new Vector2(rb.velocity.x,ziplamaHiz);
                onGround = false;
            }
        }

        if (Input.GetMouseButtonDown(0))
        {
            if (gun == false)
            {
               
                gun = true; 
                anim.SetTrigger("gun");
                Invoke("atis", 0.5f);
                seskaynak.PlayOneShot(gunSound);
            }
        }
        if (gun == true) 
        {
            ataksuresi -= Time.deltaTime;

        }
        else
        {
            ataksuresi = ataksuresibelirleme;
        }
        if (ataksuresi < 0) 
        {
            gun = false;
        }

    }
    private void OnCollisionEnter2D(Collision2D collision) 
    {
        
        if (collision.gameObject.tag=="engel") 
        {
            Destroy(gameObject,0.3f);
            seskaynak.PlayOneShot(characterDie);
            deadPanel.SetActive(true);

        }
        if (collision.gameObject.tag=="Ground")
        {
            onGround = true;
        }
        
       
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "levelgecmek") 
        {
            transform.Translate(0, 3.5f, 0);
            Invoke("levelgecmek", 0.3f); 
        }
        if (collision.gameObject.tag == "altin")
        {
            score++;
            scoreText.text = score.ToString();
            Destroy(collision.gameObject);

        }
    }
    public void atis()
    {

        GameObject mermi = Instantiate(shoot, transform.position, Quaternion.identity);
        if (transform.localScale.x > 0)
        {
            mermi.GetComponent<Rigidbody2D>().velocity = new Vector2(10f, 0f);
            Destroy(mermi, 1f);

        }
        else
        {
            
            mermi.GetComponent<Rigidbody2D>().velocity = new Vector2(-10f, 0f);
            Destroy(mermi, 1f);

        }
    }
    public void levelgecmek()
    {
        winPanel.SetActive(true);
        Time.timeScale = 0;
    }


}

