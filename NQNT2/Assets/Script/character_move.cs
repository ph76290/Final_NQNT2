using UnityEngine;
using System.Collections;

public class character_move : MonoBehaviour {


	private int speed = 2;
	public int speedrun;
    private int jump = 7;
    public int gravit;
    CharacterController player;
    private Vector3 moveDirection = Vector3.zero;
    public Animator anim;
    private float inputH;
    private float inputV;
    private bool run;


    // Use this for initialization
    void Start ()
    {
        player = GetComponent<CharacterController>();
        anim = GetComponent<Animator>();
        run = false;
    }
	
	// Update is called once per frame
	void Update ()
    {
        moveDirection.z = Input.GetAxisRaw("Vertical");
        moveDirection.x = Input.GetAxisRaw("Horizontal");
        moveDirection = transform.TransformDirection(moveDirection);
        transform.Rotate(0, Input.GetAxis("Mouse X"), 0);

        if (Input.GetKeyDown("space") && player.isGrounded)
        {
            moveDirection.y = jump;
            anim.Play("JUMP00", -1, 0f);
        }
        if (player.isGrounded == false)
        {
            moveDirection.y -= gravit * Time.deltaTime;
        }
        player.Move(moveDirection * Time.deltaTime * speed);
        if (Input.GetKey(KeyCode.LeftShift))
        {
            run = true;
			speed = speedrun;
        }
        else
        {
            run = false;
			speed = 2;
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
            moveX *= 8f;
            moveZ *= 8f;
        }
    }
}
