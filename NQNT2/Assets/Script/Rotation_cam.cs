using UnityEngine;
using System.Collections;

public class Rotation_cam : MonoBehaviour
{
    public float coef;
    int mouse_speed = 20;
    Transform pos;

    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update () {

        // if (Input.mousePosition.x == Screen.width)
        // transform.Rotate(Vector3.up);

        //if (Input.mousePosition.x == 0)
        //  transform.Rotate(Vector3.down);

        if (Input.mousePosition.y == Screen.height && Input.GetMouseButton(1))
            transform.Rotate(Vector3.left * coef);

        if (Input.mousePosition.y == 0 && Input.GetMouseButton(1))
            transform.Rotate(Vector3.right * coef);

        /*Transform CamPos = GameObject.Find("Main Camera").transform;
        Transform CharPos = GameObject.Find("Personnage").transform;
        float distance = CharPos.position.z - CamPos.position.z;
        if ( distance < 25.0f && distance > 0.0f)
        {
            transform.Translate(Vector3.forward * Input.GetAxis("Mouse ScrollWheel") * mouse_speed);
        }*/
    }
        
    
}
