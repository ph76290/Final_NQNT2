using UnityEngine;
using System.Collections;

public class SpellDisplay : MonoBehaviour {

    public GameObject Spell1;
    public GameObject Spell2;
    public GameObject Spell3;

    // Use this for initialization
    void Start ()
    {
        Spell1.SetActive(false);
        Spell2.SetActive(false);
        Spell3.SetActive(false);
    }
	
	// Update is called once per frame
	void Update ()
    {
	    
	}
}
