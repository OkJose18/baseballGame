using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JerseyColor : MonoBehaviour
{
    public GameObject batter;
    public GameObject pitcher;

    void Start()
    {
        batter.GetComponent<SpriteRenderer>().color = new Color(0, 0, 0, 1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
