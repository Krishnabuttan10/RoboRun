using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameover : MonoBehaviour
{
    public GameObject panel;
    public void gameOver()
    {
        FindObjectOfType<Audiomanager>().play("button");
        panel.SetActive(true);
        SceneManager.LoadScene("Level");
    }

}
