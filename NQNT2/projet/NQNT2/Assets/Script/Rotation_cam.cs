using UnityEngine;
using System.Collections;

public class Rotation_cam : MonoBehaviour {

    //int mouse_speed = 20;

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        
        if (Input.mousePosition.x == Screen.width)
            transform.Rotate(Vector3.up);

        if (Input.mousePosition.x == 0)
            transform.Rotate(Vector3.down);

        if (Input.mousePosition.y == Screen.height)
            transform.Rotate(Vector3.left);

        if (Input.mousePosition.y == 0)
            transform.Rotate(Vector3.right);

        //transform.Translate(Vector3.forward * Input.GetAxis("Mouse ScrollWheel") * mouse_speed);
    }
}
