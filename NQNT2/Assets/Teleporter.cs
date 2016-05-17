using UnityEngine;
using System.Collections;

public class Teleporter : MonoBehaviour {

    public Vector3 destination1;
	public Vector3 destination2;
    public Transform personnage;
    private bool b= false;
	private bool c = false;
    private bool showGUI = false;

	// Use this for initialization
	void Start () {

        personnage = GameObject.FindWithTag("Player").transform;

    }
    void Update()
    {
        if (showGUI)
        {
            if (Input.GetKeyDown("e") && b == false)
            {
                personnage.position = destination1;
                b = true;
            }

			if (Input.GetKeyDown("v") && c == false)
			{
				personnage.position = destination2;
				c = true;
			}
        }
    }
    void OnGUI()
    {
		if (showGUI && b == false && c == false)
        {
            GUI.BeginGroup(new Rect(Screen.width / 2 - 50, Screen.height / 2 - 12, 300, 300));
			GUI.Box(new Rect(0, 0, 200, 25), "Press E to teleport further");
            GUI.EndGroup();

			GUI.BeginGroup(new Rect(Screen.width / 2 - 50, Screen.height / 2 - 42, 300, 300));
			GUI.Box(new Rect(0, 0, 200, 25), "Press V to teleport in the Village");
			GUI.EndGroup();
        }
    }


    
    void OnTriggerEnter(Collider hit)
    {
        if (hit.gameObject.tag == "Player")
        {
            showGUI = true;
            
        }
    }
    void OnTriggerExit(Collider hit)
    {
        if (hit.gameObject.tag == "Player")
        {
            showGUI = false;
        }
    }


}
