using UnityEngine;
using System.Collections;

public class MouseSelection : MonoBehaviour {

	RaycastHit hit;
    bool b = false;
	public GameObject indicateur;
    int enemyhealth;
    private enemyHealth enemyHealthScript;
	public static GameObject currentlySelected;
	private Vector3 mouseDownPoint;
	private static bool selecting;
	private float raycastLength = 500f;

	void Awake ()
	{
		mouseDownPoint = Vector3.zero;
	}
    void OnGUI()
    {
        if (b)
        {
            GUI.Box(new Rect(1800, 50, 90, 20), "Health :" + enemyhealth);
        }
        
    }
    void Start()
    {
        enemyhealth = currentlySelected.GetComponent<enemyHealth>().health;
    }
	void Update()
	{
        Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
		Debug.DrawRay (ray.origin, ray.direction * raycastLength, Color.red);

		if (Physics.Raycast(ray, out hit, raycastLength)) 
		{

			if (Input.GetMouseButtonDown(0))
				mouseDownPoint = hit.point;

			//user is doing a left click
			if(Input.GetMouseButtonDown(0) && DidUserClickLeftMouse(mouseDownPoint))
			{
				Debug.Log ("left click");
				Debug.Log (hit.collider.name);

				//Something is already selected?
				/*if(selecting)
				{
					Debug.Log ("something is selecting");
					
					//deselecting it
					DeselectGameobjectIfSelected();
				}

				//hitting terrain
				if(hit.collider.name == "Terrain")
				{
					Debug.Log ("Terrain");
				}*/

				//hitting unit
				if (hit.collider.gameObject.tag == "enemy")
				{
					Debug.Log ("enemy");
                    b = true;
                    hit.collider.transform.FindChild("Selected").gameObject.SetActive(true);
					selecting = true;
				    currentlySelected = hit.collider.gameObject;
                    enemyHealthScript = currentlySelected.GetComponent<enemyHealth>();
                    enemyhealth = enemyHealthScript.health;

                }

				//hitting build
				/*if (hit.collider.gameObject.tag == "Build")
				{
					Debug.Log ("Build");
					
					hit.collider.transform.FindChild("Selected").gameObject.SetActive(true);
					selecting = true;
					currentlySelected = hit.collider.gameObject;
					Debug.Log (currentlySelected.name);
				}*/
			}
			//user is doing a right click
			/*if (Input.GetMouseButtonDown(1))
			{
				Debug.Log ("Right click");
				Debug.Log (hit.collider.name);
				
				//hitting terrain
				if(hit.collider.name == "Terrain")
				{
					Debug.Log ("Terrain");

					//user is idicating direction of unit
					if (currentlySelected.gameObject.tag == "Unit")
					{
						GameObject Target = Instantiate (indicateur, hit.point, Quaternion.identity) as GameObject;
						Target.name = "target";

						//navigation of Unit
						currentlySelected.GetComponent<NavMeshAgent>().SetDestination(Target.transform.position);
					}
				}
				
				//hitting unit
				if (hit.collider.gameObject.tag == "Unit")
				{
					Debug.Log ("Unit");
					
					hit.collider.transform.FindChild("Selected").gameObject.SetActive(true);
					selecting = true;
					currentlySelected = hit.collider.gameObject;
				}
				
				//hitting build
				if (hit.collider.gameObject.tag == "Build")
				{
					Debug.Log ("Build");

					//Something is already selected?
					if(selecting)
					{
						Debug.Log ("something is selecting");
						
						//deselecting it
						DeselectGameobjectIfSelected();
					}
					
					hit.collider.transform.FindChild("Selected").gameObject.SetActive(true);
					selecting = true;
					currentlySelected = hit.collider.gameObject;
				}
			}*/
		}
	}

	public bool DidUserClickLeftMouse(Vector3 hitPoint)
	{
		float clickZone = 2.5f;
		if ((mouseDownPoint.x < hitPoint.x + clickZone && mouseDownPoint.x > hitPoint.x - clickZone) && (mouseDownPoint.y < hitPoint.y + clickZone && mouseDownPoint.y > hitPoint.y - clickZone) && 
		    (mouseDownPoint.z < hitPoint.z + clickZone && mouseDownPoint.z > hitPoint.z - clickZone))
			return true;
		else
			return false;
	}

	public static void DeselectGameobjectIfSelected()
	{
		if (currentlySelected != null) 
		{
			currentlySelected.transform.FindChild ("Selected").gameObject.SetActive(false);
			selecting = false;
			currentlySelected = null;
		}
	}
}
