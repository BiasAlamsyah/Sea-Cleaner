using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level : MonoBehaviour
{
    // Start is called before the first frame update
    public int GoalVal;
    public int GoalCash;
    public bool goal;
    public bool goalCheck;
    public int SumSampah1;
    public int SumSampah2;
    public int SumSampah3;
    public int val;
    public int cash;
    private Diver diver;
    private SampahSpawner ss;
    void Start()
    {
        diver = GetComponent<Diver>();
        ss = GetComponent<SampahSpawner>();
        //val = 
    }

    // Update is called once per frame
    void Update()
    {
        //Spawner
       /* ss.GenerateTrash('a');
        //goalvalue = jumlah sampah yang harus di kumpulkan
        if (goal == true)
        {
            if (diver.Val ==GoalVal) { }
        }*/ 
    }
}
