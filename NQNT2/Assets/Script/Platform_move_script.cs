using UnityEngine;
using System.Collections;

public class Platform_move_script : MonoBehaviour
{

    public class ExampleClass : MonoBehaviour
    {
        /*public Animation anim;
        float vitesse = 0.2f;*/
        public Animator animator;
        public float desiredSpeed = 0.2f;

       
        

        void Start()
        {
            /*anim = GetComponent<Animation>();
            anim["Platform_move_anim"].speed = vitesse ;*/
            animator.speed = desiredSpeed;
        }

        // Update is called once per frame
        void Update()
        {
            

        }
    }
}
