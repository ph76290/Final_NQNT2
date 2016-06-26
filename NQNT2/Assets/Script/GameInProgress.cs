using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameInProgress : MonoBehaviour {

    public GameObject squelette;
    public static bool b1 = false;
    public static bool b2 = false;
    public static bool b3 = false;
    public static bool b4 = false;
    public static bool b5 = false;

    void Start()
    {
		
    }


    void Update()
    {
        if (Chest.boolean)
        {
            b1 = true;
        }
        if (b1 && squelette == null)
        {
            b2 = true;
        }

    }
    
}
