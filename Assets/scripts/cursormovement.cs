using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cursormovement : MonoBehaviour
{
    public GameObject cursor;
    public GameObject left;
    public GameObject middle;
    public GameObject right;
    public GameObject homesprite;
    public GameObject awaysprite;
    public string team = "";

    void Start()
    {
        awaysprite.SetActive(false);
        homesprite.SetActive(false);
    }
        
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            team = "Away";
            
            cursor.GetComponent<RectTransform>().localPosition = left.GetComponent<RectTransform>().localPosition;
            awaysprite.SetActive(true);
            homesprite.SetActive(false);
            PlayerPrefs.SetString("teamname" , "waves");
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            team = "Home";
            cursor.GetComponent<RectTransform>().localPosition = right.GetComponent<RectTransform>().localPosition;
            awaysprite.SetActive(false);
            homesprite.SetActive(true);
            PlayerPrefs.SetString("teamname", "knights");
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            team = "";
            cursor.GetComponent<RectTransform>().localPosition = middle.GetComponent<RectTransform>().localPosition;
            awaysprite.SetActive(false);
            homesprite.SetActive(false);
        }

        if (Input.GetKey(KeyCode.A))
        {
            team = "Away";

            cursor.GetComponent<RectTransform>().localPosition = left.GetComponent<RectTransform>().localPosition;
            awaysprite.SetActive(true);
            homesprite.SetActive(false);
            PlayerPrefs.SetString("teamname", "waves");
        }

        if (Input.GetKey(KeyCode.D))
        {
            team = "Home";
            cursor.GetComponent<RectTransform>().localPosition = right.GetComponent<RectTransform>().localPosition;
            awaysprite.SetActive(false);
            homesprite.SetActive(true);
            PlayerPrefs.SetString("teamname", "knights");
        }

        if (Input.GetKey(KeyCode.S))
        {
            team = "";  
            cursor.GetComponent<RectTransform>().localPosition = middle.GetComponent<RectTransform>().localPosition;
            awaysprite.SetActive(false);
            homesprite.SetActive(false);
        }
    }
}
