using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class warning : MonoBehaviour
{
    private void Start()
    {
        Time.timeScale = 1;
      StartCoroutine(Wait());
    }

     IEnumerator Wait()
     {
         yield return new WaitForSeconds(2f);
         Debug.Log("Level Enter");
         SceneManager.LoadScene("Level");
     }

 
}
