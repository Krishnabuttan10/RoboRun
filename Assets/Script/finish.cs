using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class finish : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Wait());
        FindObjectOfType<Audiomanager>().play("win");
    }

     IEnumerator Wait()
    {
        yield return new WaitForSeconds(5f);
        SceneManager.LoadScene("home");
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
