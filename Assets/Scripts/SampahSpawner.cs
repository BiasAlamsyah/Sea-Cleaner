using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SampahSpawner : MonoBehaviour
{
    public GameObject trash;
    public int count1 = 0;
    public int count2 = 0;
    public int count3 = 0;
    public float timea = 5;
    public int tempCount1 = 0;
    public int tempCount2 = 0;
    public int tempCount3 = 0;
    private Sampah s;
    private BoxCollider2D b;
    private SpriteRenderer sr;
    private Rigidbody2D r;
    public GameManager manager;
    public Level level;
    public Diver diver;
    public Sprite ss;
    public Sprite ss1;
    public Sprite ss2;
    public Sprite ss3;
    public Sprite ss4;
    public Sprite ss5;
    public Sprite ss6;
    public Sprite ss7;
    public Sprite ss8;
    int temp = 0;
    // Start is called before the first frame update
    void Start()
    {
        count1 = level.GetComponent<Level>().SumSampah1;
        count2 = level.GetComponent<Level>().SumSampah2;
        count3 = level.GetComponent<Level>().SumSampah3;
    }

    // Update is called once per frame
    void Update()
    {

        //check jumlah sampah a
        if (count1 > tempCount1)
        {
                GenerateTrash('a');
                tempCount1 += 1;

            temp = 0;
        }
       if(count2 >tempCount2)
        {
            GenerateTrash('b');
            tempCount2 += 1;
            temp = 0;
        }
        if (count3 > tempCount3)
        {
            GenerateTrash('c');
            tempCount3 += 1;
            temp = 0;
        }
    }
    public void GenerateTrash(char x)
    {
        if (x == 'a') {
            trash = new GameObject("trasha");
            trash.AddComponent<Sampah>();
            trash.AddComponent<SpriteRenderer>();
            trash.AddComponent<BoxCollider2D>();
            trash.AddComponent<Rigidbody2D>();
            //transform position
            trash.GetComponent<Transform>().position = new Vector3(Random.Range(-465,-37), Random.Range(-89,1520), -5);
            trash.GetComponent<Transform>().localScale = new Vector3(100, 100, 1);
            //attribut sampah
            s = trash.GetComponent<Sampah>();
            s.addCash(100);
            s.addVal(1);
            s.diver = diver;
            s.speed = Random.Range(6, 9);
            s.spawn = this;
            s.manager = manager;
            //attribute sprite renderer
            sr = trash.GetComponent<SpriteRenderer>();
            temp = Random.Range(1, 4);
            if (temp == 1)
            {
                sr.sprite = ss;
            }
            else if (temp == 2)
            {
                sr.sprite = ss1;
            }
            else if (temp == 3)
            {
                sr.sprite = ss2;
            }
            else sr.sprite = ss2;

            //attribut boxcollider
            b = trash.GetComponent<BoxCollider2D>();
            b.size = new Vector2(0.67f, 0.63f);
            b.isTrigger = true;
            //attribute rigidbody
            r = trash.GetComponent<Rigidbody2D>();
            r.gravityScale = 0;
        }
        else if (x == 'b')
        {
            trash = new GameObject("trashb");
            trash.AddComponent<Sampah>();
            trash.AddComponent<SpriteRenderer>();
            trash.AddComponent<BoxCollider2D>();
            trash.AddComponent<Rigidbody2D>();
            //transform position
            trash.GetComponent<Transform>().position = new Vector3(Random.Range(-465, -37), Random.Range(-89, 700), -5);
            trash.GetComponent<Transform>().localScale = new Vector3(100, 100, 1);
            //attribut sampah
            s = trash.GetComponent<Sampah>();
            s.addCash(250);
            s.addVal(5);
            s.diver = diver;
            s.speed = Random.Range(3, 6);
            s.spawn = this;
            s.manager = manager;
            //attribute sprite renderer
            sr = trash.GetComponent<SpriteRenderer>();
            temp = Random.Range(1, 4);
            if (temp == 1)
            {
                sr.sprite = ss3;
            }
            else if (temp == 2)
            {
                sr.sprite = ss4;
            }
            else if (temp == 3)
            {
                sr.sprite = ss5;
            }
            else sr.sprite = ss5;

            //attribut boxcollider
            b = trash.GetComponent<BoxCollider2D>();
            b.size = new Vector2(1, 1); 
            b.isTrigger = true;
            //attribute rigidbody
            r = trash.GetComponent<Rigidbody2D>();
            r.gravityScale = 0;
        }
        else if (x == 'c')
        {
            trash = new GameObject("trashc");
            trash.AddComponent<Sampah>();
            trash.AddComponent<SpriteRenderer>();
            trash.AddComponent<BoxCollider2D>();
            trash.AddComponent<Rigidbody2D>();
            //transform position
            trash.GetComponent<Transform>().position = new Vector3(Random.Range(-465, -37), Random.Range(-89, 76), -5);
            trash.GetComponent<Transform>().localScale = new Vector3(100, 100, 1);
            //attribut sampah
            s = trash.GetComponent<Sampah>();
            s.addCash(500);
            s.addVal(20);
            s.diver = diver;
            s.speed = Random.Range(1, 3);
            s.spawn = this;
            s.manager = manager;
            //attribute sprite renderer
            sr = trash.GetComponent<SpriteRenderer>();
            temp = Random.Range(1, 4);
            if (temp == 1)
            {
                sr.sprite = ss6;
            }
            else if (temp == 2)
            {
                sr.sprite = ss7;
            }
            else if (temp == 3)
            {
                sr.sprite = ss8;
            }
            else sr.sprite = ss8;

            //attribut boxcollider
            b = trash.GetComponent<BoxCollider2D>();
            b.size = new Vector2(1, 1);
            b.isTrigger = true;
            //attribute rigidbody
            r = trash.GetComponent<Rigidbody2D>();
            r.gravityScale = 0;
        }
    }
    //Touch function
    void OnTriggerEnter2D(Collider2D col)
    {
       
    }
    
}
