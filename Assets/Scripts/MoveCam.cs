using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCam : MonoBehaviour
{
    public Diver diver;
    private float temp1;
    private float temp2;
    private float speed;
    public GameManager manager;
    // Start is called before the first frame update
    void Start()
    {
        diver = diver.GetComponent<Diver>();
        PlayerPrefs.SetFloat("temp1", diver.transform.position.y);
    }

    // Update is called once per frame
    void Update()
    {
        if (manager.gameOver != true)
        {
            speed = PlayerPrefs.GetFloat("temp1") - diver.transform.position.y;
            PlayerPrefs.SetFloat("temp1", diver.transform.position.y);
            if (transform.position.y - diver.transform.position.y >= 280)
            {
                transform.position = new Vector3(960, Input.mousePosition.y + 280*speed, -10);
            }
            else if (diver.transform.position.y - transform.position.y >= 280)
            {
                transform.position = new Vector3(960, Input.mousePosition.y - 280*speed, -10);
            }

        }
        else
        {

        }
    }
}
