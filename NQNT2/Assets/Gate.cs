using UnityEngine;
using System.Collections;

public class Gate : MonoBehaviour {

    MoveDroïd m;
    public GameObject droïd;
	// Use this for initialization
	void Start ()
    {
        m = droïd.GetComponent<MoveDroïd>();
        m.enabled = false;
    }
	
	// Update is called once per frame
	void Update () {
	
	}
    void OnTriggerEnter(Collider hit)
    {
        if (hit.gameObject.tag == "Player")
        {
            PlayerInventory.RegenMore = true;
            m.enabled = true;
        }
    }
    void OnTriggerExit(Collider hit)
    {
        if (hit.gameObject.tag == "Player")
        {
            PlayerInventory.RegenMore = false;
            m.enabled = false;
        }
    }

}
