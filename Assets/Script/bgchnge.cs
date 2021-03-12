using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bgchnge : MonoBehaviour
{
    [SerializeField] GameObject bgprefab;
    [SerializeField] GameObject bgprefab1;
    Vector2 pos,originalpos,Startpos;

    bool previousframechnged = false;
    // Start is called before the first frame update
    void Start()
    {
        pos.x = 175;
        pos.y = -58;
        Startpos = Camera.main.ScreenToWorldPoint(pos);
        bgprefab = Instantiate<GameObject>(bgprefab1, Vector2.zero, Quaternion.identity);
        originalpos = transform.localPosition;
    }

    // Update is called once per frame
    void Update()
    {
        if (originalpos == Startpos)
        {
            Destroy(bgprefab);
            int prefabnum = Random.Range(0, 1);
            if (prefabnum == 0)
            {
                bgprefab = Instantiate(bgprefab1, pos, Quaternion.identity);
            }
            else if (prefabnum == 1)
            {
                bgprefab = Instantiate(bgprefab, pos, Quaternion.identity);
            }
            else
            {
                previousframechnged = false;
            }
        }
    }
}
