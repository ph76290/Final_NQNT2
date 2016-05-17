using UnityEngine;
using System.Collections;

public class cam_script : MonoBehaviour
{
    

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        move();
        //getUnit(); 

    }

    private void move()
    {
        if (Input.GetButton("up"))
            transform.Translate(Vector3.forward);

        if (Input.GetButton("down"))
            transform.Translate(Vector3.back);

        if (Input.GetButton("left"))
            transform.Translate(Vector3.left);

        if (Input.GetButton("right"))
            transform.Translate(Vector3.right);

        


    }

   /* private void getUnit()
    { RaycastHit hit;
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit, 100))
            {
                if (hit.transform.CompareTag("Enemy"))
                {
                    Debug.Log("Touché");
                }
            }
        }
    }*/
}
