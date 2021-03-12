using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class loading : MonoBehaviour
{
    public GameObject player;
    Animator anim;
    void Start()
    {
        anim= player.GetComponent<Animator>();
        StartCoroutine(loadiing());
 
    }
    IEnumerator loadiing()
    {
        anim.SetBool("Run",true);
        yield return new WaitForSeconds(3f);
        SceneManager.LoadScene("home"); 
    }
   
}
