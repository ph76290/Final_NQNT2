using UnityEngine;
using System.Collections;

public class knight_move : MonoBehaviour
{

    /*
        private int speed = 3;
        public int speedrun;
        private int jump = 6;
        public int gravit;
        CharacterController player;
        private Vector3 moveDirection = Vector3.zero;
        public Animator anim;
        private float inputH;
        private float inputV;
        private bool run;


        // Use this for initialization
        void Start()
        {
            player = GetComponent<CharacterController>();
            anim = GetComponent<Animator>();
            run = false;
        }

        // Update is called once per frame
        void Update()
        {
            moveDirection.z = Input.GetAxisRaw("Vertical");
            moveDirection.x = Input.GetAxisRaw("Horizontal");
            moveDirection = transform.TransformDirection(moveDirection);
            transform.Rotate(0, Input.GetAxis("Mouse X"), 0);

            if (Input.GetKeyDown("space") && player.isGrounded)
            {
                moveDirection.y = jump;
                anim.Play("great_sword_jump");
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

            anim.SetFloat("walk", inputH);
            anim.SetFloat("walk_back", inputV);
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
        }*/

    public int gravity;
    public float speedRotate;
    public Animator anim;
    public int speedRun;
    public int speed;
    private CharacterController controller;
    private Vector3 moveDirection;
    private float deltaTime;
    public GameObject characterContent;
    private bool runAnim;
    public float jump;
    
    void Start()
        {
        controller = characterContent.GetComponent<CharacterController>();
        characterContent = GameObject.Find("knight");
        }

    void Update()
    {
        
        deltaTime = Time.deltaTime;
        runAnim = false;
        if (controller.isGrounded)
        {
            if (Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift))
            {
                moveDirection = new Vector3(0, 0, Input.GetAxis("Vertical") * speedRun);
                runAnim = true;
            }
            else
                moveDirection = new Vector3(0, 0, Input.GetAxis("Vertical") * speed);

            if (Input.GetKey(KeyCode.Z))
            {
                anim.SetBool("walk", true);
                runAnim = true;
            }      
            else
            {
                anim.SetBool("walk", false);
                runAnim = false;
            }

            if (Input.GetKey(KeyCode.LeftShift) && runAnim)
                anim.SetBool("run", true);
            else
                anim.SetBool("run", false);

            if (Input.GetKey(KeyCode.S))
            {
                anim.SetBool("walk_back", true);
            }
            else
                anim.SetBool("walk_back", false);


            if (Input.GetKeyDown("space") && controller.isGrounded)
            {
                moveDirection.y = jump;
                anim.Play("Jump");
            }
            if (controller.isGrounded == false)
            {
                moveDirection.y -= gravity * Time.deltaTime;
            }
        }

        moveDirection = transform.TransformDirection(moveDirection);

        transform.Rotate(new Vector3(0, Input.GetAxis("Horizontal") * speedRotate * deltaTime, 0));

        moveDirection.y -= gravity;

        controller.Move(moveDirection * deltaTime);
    }
    /*
    private int speed = 3;
    public int speedrun;
    private int jump = 6;
    public int gravit;
    CharacterController player;
    private Vector3 moveDirection = Vector3.zero;
    public Animator anim;
    private float inputH;
    private float inputV;
    private bool run;


    // Use this for initialization
    void Start()
    {
        player = GetComponent<CharacterController>();
        anim = GetComponent<Animator>();
        run = false;
    }

    // Update is called once per frame
    void Update()
    {
        moveDirection.z = Input.GetAxisRaw("Vertical");
        moveDirection.x = Input.GetAxisRaw("Horizontal");
        moveDirection = transform.TransformDirection(moveDirection);
        transform.Rotate(0, Input.GetAxis("Mouse X"), 0);

        if (Input.GetKeyDown("space") && player.isGrounded)
        {
            moveDirection.y = jump;
            anim.Play("Jump", -1, 0f);
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
    }*/
}
