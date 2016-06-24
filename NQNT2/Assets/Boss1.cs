﻿using UnityEngine;
using System.Collections;

public class Boss1 : MonoBehaviour
{
    int nb = 0;
    float distance = 0f;
    private GameObject Target1;
    //Vector3 pos = GameObject.Find("Personnage").transform.position;
    float lookAtDistance = 25.0f;
    float chaseRange = 15.0f;
    float attackRange = 4.5f;
    float maxRange = 3f;
    float moveSpeed = 5.0f;
    float Damping = 6.0f;
    int attackRepeatTime = 3;
    public Collider weapon;

    public int Damage = 20;
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
        else if (distance < chaseRange && distance > maxRange && enemyHealth_mutant.move)
        {
            chase();
        }
        else if(enemyHealth_mutant.move)
            anim.Play("idle");

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
        anim.Play("walking");

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
            
            foreach (AnimationState state in anim)
            {
                state.speed = 1.2f;
            }
            if (cpt <= 0 || n == 0)//&& weapon.gameObject.name == "Health")
            {
                if (nb % 4 != 0)
                {
                    nb++;
                    anim.Play("attack");
                    if (Target1.name == "Personnage")
                        PlayerInventory.currentHealth -= (Damage * 20 / PlayerInventory.currentArmor);
                    else
                        PlayerInventory2.currentHealth -= (Damage * 20 / PlayerInventory2.currentArmor);
                }
                else
                {
                    nb++;
                    anim.Play("kicking");
                    if (Target1.name == "Personnage")
                        PlayerInventory.currentHealth -= ((2 * Damage) * 20 / PlayerInventory.currentArmor);
                    else
                        PlayerInventory2.currentHealth -= ((2 * Damage) * 20 / PlayerInventory2.currentArmor);
                }
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

    void ApplyDamage()
    {
        chaseRange += 30;
        moveSpeed += 2;
        lookAtDistance += 40;
    }

}

