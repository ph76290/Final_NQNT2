using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class EnemyStats : MonoBehaviour {

    public GameObject TrackObject;
    public Vector3 Offset;
    float limiteDetection = 250.0f;
    Ray ray;
    RaycastHit hit;

    void Detect()
    {
        ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        //if (Physics.Raycast(ray, hit.point, limiteDetection))
        {
            Debug.Log("aaaaaaaaaaa");
            if (hit.transform.CompareTag("enemy"))
            {
                Debug.Log("fufufufufufufufu");
            }
        }
    }
}
