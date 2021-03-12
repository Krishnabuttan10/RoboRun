using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class exa : MonoBehaviour
{
    Vector3 pos;
    // Start is called before the first frame update
    void Start()
    {

        pos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            pos.x += .5f;
            transform.position = pos;
        }
        
    }
}
