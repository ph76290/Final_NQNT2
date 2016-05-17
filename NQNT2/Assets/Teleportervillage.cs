using UnityEngine;
using System.Collections;

public class Teleportervillage : MonoBehaviour {

	public Vector3 destination1;
	public Transform personnage;
	private bool b= false;
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
		}
	}
	void OnGUI()
	{
		if (showGUI && b == false)
		{
			GUI.BeginGroup(new Rect(Screen.width / 2 - 50, Screen.height / 2 - 12, 300, 300));
			GUI.Box(new Rect(0, 0, 200, 25), "Press E to teleport");
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
