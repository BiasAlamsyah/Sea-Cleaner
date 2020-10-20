using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sampah : MonoBehaviour
{
    private int cash;
    private int value;
    public int speed = 3;
    public Diver diver;
    public bool checkDes;
    public SampahSpawner spawn;
    public GameManager manager;
    // Start is called before the first frame update
    void Start()
    {
        diver = diver.GetComponent<Diver>();
        cash = 100;
        value = 1;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(transform.position.x + speed, transform.position.y, -5);
        if (transform.position.x >= 2000)
        {
            speed = speed * -1;
        }
        else if (transform.position.x <= -10) {
            if (speed < 0)
            {
                speed = speed * -1;
            }
        }
        if (manager.GetComponent<GameManager>().gameOver == true)
        {
            speed = 0;
        }
    }
    public void addCash(int x)
    {
        cash = x;
    }
    public void addVal(int x)
    {
        value = x;
    }
    public int getVal()
    {
        return value;
    }
    public int getCash()
    {
        return cash;
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name.Equals("diver"))
        {
            if (this.gameObject.name.Equals("trasha")&& diver.Lvl>=1)
            {
                Destroy(gameObject);
                spawn.GetComponent<SampahSpawner>().tempCount1 -= 1;
            }
            else if (this.gameObject.name.Contains("trashb") && diver.Lvl >= 2)
            {
                Destroy(gameObject);
                spawn.GetComponent<SampahSpawner>().tempCount2 -= 1;
            }
            else if (this.gameObject.name.Contains("trashc") && diver.Lvl >= 3)
            {
                spawn.GetComponent<SampahSpawner>().tempCount3 -= 1;
                Destroy(gameObject);
            }
        }
    }
}
