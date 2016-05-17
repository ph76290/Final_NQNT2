using UnityEngine;
using System.Collections;

public class Move : MonoBehaviour {
	private float speed = 0.25f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        move();

	
	}

    private void move()
    {
        if (Input.GetButton("up"))
			transform.Translate(Vector3.forward * speed);

        if (Input.GetButton("down"))
			transform.Translate(-Vector3.forward * speed);

        if (Input.GetButton("left"))
			transform.Rotate(Vector3.down * 5);

		if (Input.GetButton ("right"))
			transform.Rotate (Vector3.up * 5);

        /*if (Input.mousePosition.x == Screen.width)
            transform.Translate(Vector3.right);

        if (Input.mousePosition.x == 0)
            transform.Translate(Vector3.left);

        if (Input.mousePosition.y == Screen.height)
            transform.Translate(Vector3.up);

        if (Input.mousePosition.y == 0)
            transform.Translate(Vector3.down);*/

        


    }

}
