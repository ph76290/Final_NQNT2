using UnityEngine;
using System.Collections;

public class ChangeCharacter : MonoBehaviour {
    bool SwitchUP;
    public static bool c;
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
        c = true;
        SwitchUP = true;
    }

    // Update is called once per frame
    void Update()
    {
        
        if (SwitchUP && Input.GetKeyDown("n"))
        {
            showGUI = !showGUI;
        }
    }

    void OnGUI()
    {

        if (c)
            GUI.Box(new Rect(90, 150, 90, 30), "Armor :" + PlayerInventory.currentArmor);
        else
            GUI.Box(new Rect(90, 150, 90, 30), "Armor :" + PlayerInventory2.currentArmor);
        if (showGUI == true)
        {
            if (SwitchUP && GUI.Button(new Rect(10, 160, 50, 50), "1") && SwitchUP)
            {
                /*camera1.SetActive(true);
                camera2.SetActive(false);
                monScript = character1.GetComponent<character_move>();
                monScript.enabled = true;
                monScript = character2.GetComponent<character_move>();
                monScript.enabled = false;*/
                SwitchUP = false;
                c = true;
                PlayerInventory.regenMana = true;
                character1.SetActive(true);
                character1.transform.position = character2.transform.position;
                character2.SetActive(false);
                StartCoroutine(switchDelay());
            }

            if (SwitchUP && GUI.Button(new Rect(10, 210, 50, 50), "2"))
            {
                /*camera1.SetActive(false);
                camera2.SetActive(true);
                monScript = character1.GetComponent<character_move>();
                monScript.enabled = false;
                monScript = character2.GetComponent<character_move>();
                monScript.enabled = true;*/
                SwitchUP = false;
                c = false;
                character1.SetActive(false);
                character2.transform.position = character1.transform.position;
                character2.SetActive(true);
                StartCoroutine(switchDelay());
            }

        }
    }
    IEnumerator switchDelay()
    {
        SwitchUP = false;
        yield return new WaitForSeconds(3);
        SwitchUP = true;
    }

}
