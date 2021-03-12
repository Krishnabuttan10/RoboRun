using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
public class homeScreen : MonoBehaviour
{
    public void play()
    {
        SceneManager.LoadScene("warning");
        FindObjectOfType<Audiomanager>().play("button");

    }
    public void option()
    {
        FindObjectOfType<Audiomanager>().play("button");
    }

    public void Exit()
    {

        Application.Quit();
        FindObjectOfType<Audiomanager>().play("button");
    }
}
