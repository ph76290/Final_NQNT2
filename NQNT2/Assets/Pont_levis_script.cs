using UnityEngine;
using System.Collections;

public class Pont_levis_script : MonoBehaviour {


	Animator B;
	public GameObject Enemy_1;
	public GameObject Enemy_2;
	public int rotation_max;
	public float speed;

	// Use this for initialization
	void Start () {	

		B =  gameObject.GetComponent<Animator>();

	}
	
	// Update is called once per frame
	void Update () {

		if ((Enemy_1 == null && Enemy_2 == null)) {
			Debug.Log ("BOUGE");
			if (transform.rotation.z < rotation_max) {

				transform.Rotate(-Vector3.forward*speed);
			}
				
			//B.Play("Pont_Anim");
			//gameObject.GetComponent<Animator>().Play("Pont_Anim", -1, 0f);

		}

	
	}
}
