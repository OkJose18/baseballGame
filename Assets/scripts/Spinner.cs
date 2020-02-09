using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spinner : MonoBehaviour
{
    public GameObject swing;
    public GameObject spinner;
    public GameObject pointer;
    public GameObject Red;
    public GameObject Green;
    public GameObject gameController;
    public Animator ballanim;
    public Animator batanim;
    public bool spin = false;
    public float pointerspeed = 89;
    public float RedAmount;
    public float RedtoGreenRatio;
    public float slowdownspeed = 1;
    public float stop = 0;
    public GameObject randnum;
    public GameObject gameManager;

    // Start is called before the first frame update
    void Start()
    {
        RedAmount = gameController.GetComponent<UserTeam>().otherteamcontrol / gameController.GetComponent<UserTeam>().contact;
        Debug.Log(RedAmount);
        spinner.SetActive(false);
        pointer.SetActive(false);
        pointerspeed = Random.Range(100, 200);
        slowdownspeed = Random.Range(0.1f, 0.9f);
    }
        
    // Update is called once per frame
    void Update()
    {
        if (spin)
        {
            spinner.SetActive(true);
            pointer.SetActive(true);
            RotateLeft();
        }
    }

    void RotateLeft()
    {
        if (pointerspeed > 0 && spin)
        {
            pointerspeed -= slowdownspeed;
        }
        if (pointerspeed < 10 && spin)
        {
            spin = false;
            pointerspeed = 0;
            spinner.SetActive(false);
            pointer.SetActive(false);
            RedorGreen();
        }
        pointer.transform.Rotate(Vector3.forward * pointerspeed * 0.5f);
    }

    public void activateSpinner()
    {
        spin = true;
        pointerspeed = Random.Range(50, 100);
    }

    public float spinnerZ()
    {
        return pointer.transform.eulerAngles.z;
    }

    public string RedorGreen()
    {
        RedtoGreenRatio = RedAmount * 360;
        Debug.Log(RedAmount);
        if (spinnerZ() >= 60 && spinnerZ() <= RedtoGreenRatio + 60)
        {
            gameManager.GetComponent<GameManager>().activateOutText();
            gameManager.GetComponent<GameManager>().OutCounter();
            ballanim.SetBool("pitch", true);
            batanim.SetBool("miss", true);
            return "Red";
        }
        gameManager.GetComponent<GameManager>().activateHitText();
        gameManager.GetComponent<GameManager>().RunnerOn();
        ballanim.SetBool("throw", true);
        batanim.SetBool("swing", true);
        return "Green";
    }
}