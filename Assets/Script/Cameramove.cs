using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cameramove : MonoBehaviour
{
   /* public GameObject player;
    Transform playertransform;
    public float Leftlimit, rightlimit;
    public float Bottomlimit, Toplimit;
    private void Start()
    {
        playertransform = player.transform;
    }
   
    private void LateUpdate()
    {
        //temporary pos of camera in temp
        Vector3 temp = transform.position;
        temp.x = playertransform.position.x;
        temp.x +=Mathf.Clamp(transform.position.x, Leftlimit, rightlimit);
        temp.y = playertransform.position.y;
        temp.y += Mathf.Clamp(transform.position.y, Bottomlimit, Toplimit);
        transform.position = temp;
    }
    */
     [SerializeField] GameObject Player;
    Transform playertransform;
   
     [SerializeField] float leftLimit;
     [SerializeField] float rightlimit;
     [SerializeField] float toplimit;
     [SerializeField] float bottomlimit;

    private void Start()
    {
        playertransform = Player.transform;
    }

    private void LateUpdate()
     {
         transform.position = new Vector3(Mathf.Clamp(playertransform.position.x, leftLimit, rightlimit), Mathf.Clamp(playertransform.position.y, bottomlimit, toplimit),-890f);
    }


    /* public GameObject player;
     Vector3 obj, campos;

     private void Start()
     {
         campos = Camera.main.transform.position;
         obj = Camera.main.transform.position - player.transform.position;
     }

     private void Update()
     {
         Camera.main.transform.position = new Vector3(player.transform.position.x + 100f, player.transform.position.y + 2f, obj.z);
     }*/

}
