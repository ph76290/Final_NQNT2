using UnityEngine;
using System.Collections;

public class FireDetect : MonoBehaviour {

    public int TheDamage = 50;
	// Use this for initialization
	void Start ()
    {
	
	}
	
	// Update is called once per frame
	void Update ()
    {

	}
    void OnTriggerEnter(Collider hit)
    {
            if (hit.gameObject.tag == "enemy")
            {
                //enemyHealth.health -= TheDamage;
                hit.transform.SendMessage("ApplyDamage", TheDamage, SendMessageOptions.DontRequireReceiver);
            }
    }
}
