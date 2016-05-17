using UnityEngine;
using System.Collections;

public class ChangeCharacter : MonoBehaviour {

    bool showGUI = false;
    public GameObject character1;
    public GameObject character2;
    public GameObject camera1;
    public GameObject camera2;
    character_move monScript;

    // Use this for initialization
    void Start()
    {
        /*monScript = character2.GetComponent<character_move>();
        monScript.enabled = false;*/
        character2.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKeyDown("n"))
        {
            showGUI = !showGUI;
        }
    }

    void OnGUI()
    {

        if (showGUI == true)
        {

            if (GUI.Button(new Rect(10, 160, 50, 50), "1"))
            {
                /*camera1.SetActive(true);
                camera2.SetActive(false);
                monScript = character1.GetComponent<character_move>();
                monScript.enabled = true;
                monScript = character2.GetComponent<character_move>();
                monScript.enabled = false;*/
                character1.SetActive(true);
                character2.SetActive(false);
            }

            if (GUI.Button(new Rect(10, 210, 50, 50), "2"))
            {
                /*camera1.SetActive(false);
                camera2.SetActive(true);
                monScript = character1.GetComponent<character_move>();
                monScript.enabled = false;
                monScript = character2.GetComponent<character_move>();
                monScript.enabled = true;*/
                character1.SetActive(false);
                character2.SetActive(true);
            }

        }
    }

}
