using UnityEngine;
using System.Collections;

public class LockRotation : MonoBehaviour {


	void Update ()
    {
        transform.eulerAngles = new Vector3(0, transform.eulerAngles.y, transform.eulerAngles.z);
	}
}
