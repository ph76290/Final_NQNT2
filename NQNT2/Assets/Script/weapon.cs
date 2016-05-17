using UnityEngine;
using System.Collections;

public class weapon : MonoBehaviour {

    static Ray ray;
    public int TheDamage = 50;
    private float Distance;
    public float MaxDistance = 1.5f;
    float DamageDelay = 0.6f;
	// Use this for initialization
	void Start ()
    {
	
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            AttackDamage();
        }
	}
    void AttackDamage()
    {
        RaycastHit hit;
        Camera camera = GetComponent<Camera>();
        ray = camera.ScreenPointToRay(new Vector3(Screen.width / 2, Screen.height / 2, 0));
        if (Physics.Raycast(ray, out hit))
        {
            Distance = hit.distance;
            if (Distance < MaxDistance)
            {
                hit.transform.SendMessage("ApplyDamage", TheDamage, SendMessageOptions.DontRequireReceiver);
            }
        }
    }
}
