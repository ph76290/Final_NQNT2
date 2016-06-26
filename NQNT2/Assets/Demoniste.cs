using UnityEngine;
using System.Collections;
using System.Resources;
using System;

public class Demoniste : MonoBehaviour
{

    bool waiting = false;
    int nb;
    float distance = 0f;
    private GameObject Target1;
    //Vector3 pos = GameObject.Find("Personnage").transform.position;
    float lookAtDistance = 40.0f;
    float attackRange = 20.0f;
    float maxRange = 3f;
    float moveSpeed = 5.0f;
    float Damping = 6.0f;
    int attackRepeatTime = 5;
    public Collider weapon;
    private int Damage = Convert.ToInt32(400 / PlayerInventory.currentArmor);
    private int Damage2 = Convert.ToInt32(400 / PlayerInventory2.currentArmor);
    private float attackTime;
    public CharacterController controller;
    float gravity = 10.0f;
    private Vector3 moveDirection = Vector3.zero;
    Animation anim;
    float cpt = 0.5f;



    private NavMeshAgent agent;
    // Use this for initialization
    void Start()
    {
        nb = 0;
        attackTime = Time.time;
        anim = GetComponent<Animation>();
    }

    // Update is called once per frame
    void Update()
    {
        if (ChangeCharacter.c == false)
        {
            Target1 = GameObject.Find("knight");
        }
        else if (ChangeCharacter.c)
        {
            Target1 = GameObject.Find("Personnage");
        }
        //moveDirection.y = 0f;
        distance = Vector3.Distance(Target1.transform.position, transform.position);
        if (distance < lookAtDistance)
        {
            lookAt();
        }
        if (distance < attackRange)
        {
            attack();
        }
        else if (enemyHealth.move)
            anim.Play("Idle2");

        //agent = GetComponent<NavMeshAgent>();
        //NavMeshPath chemin = new NavMeshPath();
        //agent.destination = GameObject.Find("Personnage").transform.position;
    }

    void lookAt()
    {
        var rotation = Quaternion.LookRotation(Target1.transform.position - transform.position);
        transform.rotation = Quaternion.Slerp(transform.rotation, rotation, Time.deltaTime * Damping);
    }
    void chase()
    {
        anim.Play("run");

        moveDirection = transform.forward;
        moveDirection *= moveSpeed;

        moveDirection.y -= gravity * Time.deltaTime;
        controller.Move(moveDirection * Time.deltaTime);
    }
    void attack()
    {
        int n = 0;
        if (Time.time > attackTime)
        {
            if (cpt <= 0 || n == 0)//&& weapon.gameObject.name == "Health")
            {
                StartCoroutine(wait());
                if (nb % 3 == 0)
                {
                    anim.CrossFade("Magic Attack2", 1.2f);
                    if (waiting)
                    {
                        waiting = false;
                        if (Target1.name == "Personnage")
                        {
                            PlayerInventory.currentHealth -= Convert.ToInt32(400 / PlayerInventory.currentArmor);
                        }
                        else
                        {
                            PlayerInventory2.currentHealth -= Convert.ToInt32(400 / PlayerInventory2.currentArmor);
                        }
                    }
                    
                }
                else if (nb % 3 == 1)
                {
                    anim.CrossFade("Magic Attack3", 1.2f);
                    if (waiting)
                    {
                        anim.Play("Magic Attack3");
                        if (Target1.name == "Personnage")
                        {
                            PlayerInventory.currentHealth -= Convert.ToInt32(400 / PlayerInventory.currentArmor);
                        }
                        else
                        {
                            PlayerInventory2.currentHealth -= Convert.ToInt32(400 / PlayerInventory2.currentArmor);
                        }
                    }
                }
                else
                {
                    anim.CrossFade("Magic Attack", 1.2f);
                    if (waiting)
                    {
                        anim.Play("Magic Attack");
                        if (Target1.name == "Personnage")
                        {
                            PlayerInventory.currentHealth -= Convert.ToInt32(400 / PlayerInventory.currentArmor);
                        }
                        else
                        {
                            PlayerInventory2.currentHealth -= Convert.ToInt32(400 / PlayerInventory2.currentArmor);
                        }
                    }
                }
                nb++;

                n++;
            }
            else
            {
                cpt -= Time.deltaTime;
            }
            //Target.SendMessage("ApplyDamage", Damage);
            Debug.Log("The Enemy Has Attacked");
            attackTime = Time.time + attackRepeatTime;
        }
    }

    IEnumerator wait()
    {
        yield return new WaitForSeconds(2.0f);
        waiting = true;
    }

    void ApplyDamage()
    {
        moveSpeed += 2;
        lookAtDistance += 40;
    }

}
