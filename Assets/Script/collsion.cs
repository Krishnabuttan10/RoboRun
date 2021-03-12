using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class collsion : MonoBehaviour
{
    public GameObject player,Ui;
    
    public Text Score,mush,Score2,mush2;
    int count, extra,countdown;
    public GameObject panel,winpanel,trypanel;

    private void Start()
    {
        count = 0;extra = 0;
        setScoretext();

    }



    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Coin")
        {
            FindObjectOfType<Audiomanager>().play("coin");
            Destroy(col.gameObject);
            count = count + 10;
            Debug.Log(count + "  : ");
            setScoretext();
        }

        if (col.gameObject.tag == "extra")
        {
            FindObjectOfType<Audiomanager>().play("mush");
            Destroy(col.gameObject);
            extra = extra + 1;
            Debug.Log(extra + "  : ");
            setScoretext();
        }

        if (col.gameObject.tag=="Finish")
        {
            FindObjectOfType<Audiomanager>().play("win");
            Ui.SetActive(false);
            if (count >= 150 && extra >= 5)
            {
                winpanel.SetActive(true);
            }
            else
            {
                trypanel.SetActive(true);
            }
        }
    }
    private void OnCollisionEnter2D(Collision2D col)
    {
       

        if(col.gameObject.tag=="water")
        {
            FindObjectOfType<Audiomanager>().play("die");
            Destroy(player);
            panel.SetActive(true);
        }

        if(col.gameObject.tag=="die")
        {
            FindObjectOfType<Audiomanager>().play("die");
            Destroy(player);
            panel.SetActive(true);
        }

        
    }
    void setScoretext()
    {
        Score.text = "Score :" + count.ToString();
        Score2.text = "Score : " + count.ToString();
        mush.text = "X " + extra.ToString();
        mush2.text = "X  " + extra.ToString();
        Debug.Log(Score + "  : ");
        
    }
   
    
}
