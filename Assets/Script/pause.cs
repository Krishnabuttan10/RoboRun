using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;
public class pause : MonoBehaviour
{
    public GameObject bg;
    AudioSource audiosorc;
    // public TextMeshProUGUI timer;
    public Text timer;
    public GameObject panel, ui, gameov;
    float wait;
    int pauseval = 0;
    int countdown = 75;
    bool paused;
    private void Start()
    {
        //note.SetActive(true);
        countdown = 75;
        audiosorc = bg.GetComponent<AudioSource>();
        //      CountDown();
        paused = false ;

    }

    private void Update()
    {
        if (wait == 0)
        {
            wait = 1;
            CountDown();
        }
        else
        {
            wait -= Time.deltaTime;
            if (wait < 0)
            {
                wait = 0;
            }

        }

    }

    public void paause()
    {
        FindObjectOfType<Audiomanager>().play("button");
        panel.SetActive(true);
        ui.SetActive(false);
        paused = true;
        pauseval = 1;
        songpause();
 
        //FindObjectOfType<Audiomanager>();
        pausnplay();
    }
    public void Conti()
    {
        FindObjectOfType<Audiomanager>().play("button");

        panel.SetActive(false);
        paused = false;
        pauseval = 0;
        ui.SetActive(true);
        Debug.Log(pauseval);
        pausnplay();
        songpause();
        Debug.Log(pauseval);

    }

    public void option()
    {
        FindObjectOfType<Audiomanager>().play("button");
        paused = false;
        Debug.Log("restart");
        pauseval = 0;

        SceneManager.LoadScene("Level");
    }


    public void doQuit()
    {
        FindObjectOfType<Audiomanager>().play("button");
        paused = false;
        Debug.Log("home");
        pauseval = 0;
        songpause();
        SceneManager.LoadScene("home");            
    }
    
    public void songpause()
    {
        if (paused == true)
        {
            audiosorc.Pause();
 
        }
        else if (paused == false)
        {
            audiosorc.Play();
  
        }
    }

   public void CountDown()
    {
        if (countdown > 0)
        {
            TimeSpan sptime = TimeSpan.FromSeconds(countdown);
            timer.text = "Time:\n" + sptime.Minutes + ":" + sptime.Seconds;
            countdown--;
            
        }
        else if (countdown <= 0)
        {
            gameov.SetActive(true);
        }

    }

    void pausnplay()
    {
        if (pauseval == 1)
        {
            Time.timeScale = 0;
            Debug.Log("pause");
        }
        else if (pauseval == 0)
        {
            Debug.Log("hello");
            Time.timeScale = 1;
            Debug.Log("Continue");
        }
    }
}
