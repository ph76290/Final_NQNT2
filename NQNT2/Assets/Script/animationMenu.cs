using UnityEngine;
using System.Collections;

public class animationMenu : MonoBehaviour {

    Animator anim;
    // Use this for initialization
    void Start ()
    {
        anim = GetComponent<Animator>();
	}
    void animplay()
    {
        anim.Play("JUMP00", -1, 0f);
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
