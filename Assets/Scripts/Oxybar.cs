using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Oxybar : MonoBehaviour
{
    // Start is called before the first frame update
    public Diver diver;
    public float temp = 0;
    public RectTransform rt;
    void Start()
    {
        diver = diver.GetComponent<Diver>();
        rt = GetComponent<RectTransform>();
    }

    // Update is called once per frame
    void Update()
    {
        temp = diver.oxy / 100 * 292;
        if (temp > 292)
        {
            temp = 292;
        }

        rt.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, temp);

    }
}
