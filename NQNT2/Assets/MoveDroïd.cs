using UnityEngine;
using System.Collections;

public class MoveDroïd : MonoBehaviour {

    float Damping = 6.0f;
    float distance = 0f;
    private GameObject Target1;
    //public Transform Target2;
    private Vector3 moveDirection = Vector3.zero;
    float moveSpeed = 5.0f;
    public CharacterController controller;

    // Use this for initialization
    void Start ()
    {
	
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (ChangeCharacter.c == false)
        {
            Target1 = GameObject.Find("knight");
        }
        else if (ChangeCharacter.c)
        {
            Target1 = GameObject.Find("Personnage");
        }
        if (Target1 != null)
        {
            distance = Vector3.Distance(Target1.transform.position, transform.position);
            if (distance > 5.0f)
            {
                var rotation = Quaternion.LookRotation(Target1.transform.position - transform.position);
                transform.rotation = Quaternion.Slerp(transform.rotation, rotation, Time.deltaTime * Damping);
                moveDirection = transform.forward;
                moveDirection *= moveSpeed;
                controller.Move(moveDirection * Time.deltaTime);
            }
        }/*
        else
        {
            distance = Vector3.Distance(Target2.position, transform.position);
            if (distance > 5.0f)
            {
                var rotation = Quaternion.LookRotation(Target2.position - transform.position);
                transform.rotation = Quaternion.Slerp(transform.rotation, rotation, Time.deltaTime * Damping);
                moveDirection = transform.forward;
                moveDirection *= moveSpeed;
                controller.Move(moveDirection * Time.deltaTime);
            }
        }*/
    }
}
