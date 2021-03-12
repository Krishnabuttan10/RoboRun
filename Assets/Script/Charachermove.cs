using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Charachermove : MonoBehaviour
{
    Animator anim;
    float speed = 10f;

    Vector3 pos;
    int ruun, runl, juump, sliide;

   // public bool isgrounded;
  //  public Transform groundcheck;


    void Start()
    {
        Time.timeScale = 1;
        anim = GetComponent<Animator>();
    }

    void Update()
    {       
        pos = transform.position;
        if (ruun == 1)
        {
            pos.x = pos.x + 7f;
            transform.position = pos;
            Debug.Log("running");
        }

        if (runl == 1)
        {
            pos.x = pos.x - 7f;
            transform.position = pos;
        }

        if (juump == 1)
        {
            pos.y = pos.y + 20f;
            transform.position = pos;
            /* if (isgrounded == true)
             {
                 pos.y = pos.y + 20f;
                 transform.position = pos;
                 //gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0f,20f),ForceMode2D.Impulse);
             }*/
        }
        if (sliide == 1)
        {
            pos.x += 5f;
        }
    }
    public void run()
    {
        Debug.Log("hello"); 
        FindObjectOfType<Audiomanager>().play("button");
        transform.localScale = new Vector3(34.93632f, 34.93632f, 34.93632f);       
        anim.SetBool("Run", true);
        ruun = 1;      
        Debug.Log(transform.position);        
    }

    public void run_idle()
    {
        // FindObjectOfType<Audiomanager>().play("");
        anim.SetBool("Run", false);
        ruun = 0;
    }

    public void run_left()
    {        
        FindObjectOfType<Audiomanager>().play("button");        
        transform.localScale = new Vector3(-34.93632f, 34.93632f, 34.93632f);
        anim.SetBool("Run", true);
        runl = 1;
    }

    public void runleft_idle()
    {
        anim.SetBool("Run", false);
        runl = 0;

    }
    public void jump()
    {
        FindObjectOfType<Audiomanager>().play("jump");
        anim.SetTrigger("Jumping");
        juump = 1;
    }
    public void jump_idle()
    {
        anim.SetBool("Idle", true);
        juump = 0;
    }

    public void slide()
    {

        FindObjectOfType<Audiomanager>().play("button");
        anim.SetTrigger("Sliding");
        sliide = 1;
    }
    public void slide_idle()
    {
        anim.SetBool("Idle", true);
        sliide = 0;
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "m_floor")
        {
            transform.SetParent(collision.gameObject.transform);
        }

    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        transform.SetParent(null);
    }
}
