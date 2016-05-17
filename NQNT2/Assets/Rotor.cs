using UnityEngine;
using System.Collections;

public class Rotor : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		transform.Rotate(Vector3.one * 4 * Time.deltaTime);
	
	}
}
