using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Diver diver;
    public Level level;
    public bool gameOver;
    // Start is called before the first frame update
    void Start()
    {
        diver = GetComponent<Diver>();
        level = GetComponent<Level>();
        
        gameOver = false;
    }

    // Update is called once per frame
    void Update()
    {
        //jika game over
        
    }

}
