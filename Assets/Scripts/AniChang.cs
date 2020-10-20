using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AniChang : MonoBehaviour
{
    // Start is called before the first frame update
    public Diver diver;
    public Animator an;

    void Start()
    {
        diver=diver.GetComponent<Diver>();
        an = an.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (diver.Lvl == 2)
        {
            an.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Diver2");
        }
        else if (diver.Lvl == 3)
        {
            an.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Diver3");
        }
    }
}
