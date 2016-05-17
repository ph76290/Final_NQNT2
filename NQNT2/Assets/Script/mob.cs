using UnityEngine;
using System.Collections;

public class mob : MonoBehaviour {

    private NavMeshAgent agent;
    public GameObject particules;
    public static int vie = 50;
   

    void Start () {
        agent = GetComponent<NavMeshAgent>();
        NavMeshPath chemin = new NavMeshPath();
        //agent.destination = GameObject.Find("HeroStats").transform.position;
	}
	
	// Update is called once per frame
	void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.name == "EmptyDetect")
        {
            PlayerControl.health-= 10;
        }
        if (Input.GetButtonDown("Fire1"))//col.gameObject.name == "Bad_guy" && Input.GetButtonDown("Fire1"))
        {
            vie -= 10;
            Debug.Log("-10");
        }

    }
    void Update()
    {
        if ( vie <= 0)
        {
            Instantiate(particules, transform.position, Quaternion.identity);
            Destroy(this.gameObject);
        }
    }
}
