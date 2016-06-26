using UnityEngine;
using System.Collections;

public class Platform_perso : MonoBehaviour {

	Transform personnageT;
	bool showGUI = false;

	// Use this for initialization
	void Start () {

		personnageT = GameObject.FindWithTag ("Player").transform;
		
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnGUI()
	{
		if (showGUI )
		{
			GUI.BeginGroup(new Rect(Screen.width / 2 - 50, Screen.height / 2 - 12, 300, 300));
			GUI.Box(new Rect(0, 0, 200, 25), "hello asshole");
			GUI.EndGroup();


		}
	}

	void OnTriggerEnter(Collider hit)
	{
		if (hit.gameObject.tag == "Plateform") {
			personnageT.parent = hit.transform;
			showGUI = true;

		} 

	}

	void OnTriggerExit(Collider hit)
	{
		if (hit.gameObject.tag == "Plateform")
		{
			showGUI = false;
		}
	}
}
