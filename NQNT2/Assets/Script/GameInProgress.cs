using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameInProgress : MonoBehaviour {


    public static bool b1 = false;
    static bool b2 = false;
    static bool b3 = false;
    static bool b4 = false;
    static bool b5 = false;

    void Start()
    {
		
    }


    void Update()
    {
        if (Chest.boolean)
        {
            b1 = true;
        }

    }
}
