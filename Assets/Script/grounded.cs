﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class grounded : MonoBehaviour
{
    GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        player = gameObject.transform.parent.gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.collider.tag=="ground")
        {
           // player.GetComponent<Charachermove>().isgrounded = true;
        }
        
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.collider.tag == "ground")
        {
           // player.GetComponent<Charachermove>().isgrounded = false;
        }

       
    }
}
