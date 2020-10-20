using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movesun : MonoBehaviour
{
    // Start is called before the first frame update
    public Sprite s;
    public Sprite s2;
    public SpriteRenderer sr;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(transform.position.x + 4, transform.position.y, transform.position.z);
        if (this.transform.position.x > -450)
        {
            sr.GetComponent<SpriteRenderer>().sprite = s;
        }
        else if(this.transform.position.x >= 450)
        {
            sr.GetComponent<SpriteRenderer>().sprite = s2;
        }
        else
        {

        }
    }
}
