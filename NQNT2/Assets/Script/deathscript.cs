using UnityEngine;
using System.Collections;

public class deathscript : MonoBehaviour {



    void OnTriggerEnter(Collider hit)
    {
        if (hit.gameObject.tag == "Player")
        {
            Application.LoadLevel("Menu");
            Debug.Log("contact");
        }
    }

}
