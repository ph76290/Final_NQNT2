using UnityEngine;
using System.Collections;

public class player : MonoBehaviour {

    public Animator anim;
    public Rigidbody rbody;

    private float inputH;
    private float inputV;
    private bool run;

	// Use this for initialization
	void Start ()
    {
        anim = GetComponent<Animator>();
        rbody = GetComponent<Rigidbody>();
        run = false;
	}
	
	// Update is called once per frame
	void Update ()
    {
        /*if (Input.GetKeyDown("s"))
        {
            anim.Play("WALK00_B", -1, 0f);
        }
        if (Input.GetKeyDown("z"))
        {
            anim.Play("WALK00_F", -1, 0f);
        }
        if (Input.GetKeyDown("q"))
        {
            anim.Play("WALK00_L", -1, 0f);
        }
        if (Input.GetKeyDown("d"))
        {
            anim.Play("WALK00_R", -1, 0f);
        }*/
        if (Input.GetKeyDown("space"))
        {
            anim.Play("JUMP00", -1, 0f);
        }
        if (Input.GetKey(KeyCode.LeftShift))
        {
            run = true;
        }
        else
        {
            run = false;
        }

        if (Input.GetKey(KeyCode.Space))
        {
            anim.SetBool("jump", true);
        }
        else
        {
            anim.SetBool("jump", false);
        }
        inputH = Input.GetAxis("Horizontal");
        inputV = Input.GetAxis("Vertical");

        anim.SetFloat("inputH", inputH);
        anim.SetFloat("inputV", inputV);
        anim.SetBool("run", run);

        float moveX = inputH * 50f * Time.deltaTime;
        float moveZ = inputV * 50f * Time.deltaTime;

        if (moveZ <= 0f)
        {
            moveX = 0f;
        }
        else if (run)
        {
            moveX *= 3f;
            moveZ *= 3f;
        }

        rbody.velocity = new Vector3(moveX, 0f, moveZ);

    }
}
