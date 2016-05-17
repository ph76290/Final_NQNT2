using UnityEngine;
using System.Collections;

public class Move : MonoBehaviour {
    float turnSpeed = 10.0f;
    float moveSpeed = 10.0f;
    float mouseTurnMultiplier = 1.0f;

    private float x;
    private float z;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update ()
    {
        x = 0.0f;
        z = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;
        transform.Translate(0, 0, z);
        if (Input.GetButtonDown("q") || Input.GetButtonDown("d"))
        {
            x = Input.GetAxis("Horizontal");
        }
        if (Input.GetMouseButton(1))
        {
            x = Input.GetAxis("Mouse X") * turnSpeed * mouseTurnMultiplier;
        }
        transform.Rotate(0, x, 0);
	}

    /*private void move()
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
            transform.Translate(Vector3.down);
      }
    */
}
