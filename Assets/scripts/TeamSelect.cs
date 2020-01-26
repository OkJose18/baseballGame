using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TeamSelect : MonoBehaviour
{
    public Sprite waves;
    public Sprite knights;
    public bool flip = false;
    public GameObject awaysprite;
    public GameObject homesprite;

    public void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            if (flip)   
            {
                awaysprite.GetComponent<Image>().sprite = waves;
                homesprite.GetComponent<Image>().sprite = waves;
                PlayerPrefs.SetString("teamname", "waves");
                flip = false;
            }
            else
            {
                awaysprite.GetComponent<Image>().sprite = knights;
                homesprite.GetComponent<Image>().sprite = knights;
                PlayerPrefs.SetString("teamname", "knights");
                flip = true;
            }
        }
    }
}
