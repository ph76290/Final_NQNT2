using UnityEngine;
using System.Collections;

public class enemyHealthSpider : MonoBehaviour
{

    public static bool move = true;
    bool b = false;
    private enemyHealth enemyHealthScript;
    public static GameObject currentlySelected;
    private Vector3 mouseDownPoint;
    private static bool selecting;
    RaycastHit hit;
    private float raycastLength = 500f;
    private MouseSelection mouse;
    private int health = 50;
    int copyHealth;
    spider_bad bad_guy;
    Animation anim;
    public GameObject spider;

    public int Health
    {
        get { return copyHealth; }
    }
    void Start()
    {
        anim = GetComponent<Animation>();
    }
    void ApplyDamage(int TheDamage)
    {
        move = false;
        StartCoroutine(Move());
        health -= TheDamage;
        Debug.Log("aie");
        copyHealth = health;
        if (health <= 0)
        {
            health = 0;
            //enemy.GetComponent(Bad_guy).enabled = false;
            if (spider != null)
                bad_guy = spider.GetComponent<spider_bad>();
            StartCoroutine(Dead());
            bad_guy.enabled = false;
            anim.Play("Die");
            
        }
    }

    void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        Debug.DrawRay(ray.origin, ray.direction * raycastLength, Color.red);
        if (Physics.Raycast(ray, out hit, raycastLength))
        {
            if (Input.GetMouseButtonDown(0))
            {
                if (hit.collider.gameObject.tag == "enemy")
                {
                    Debug.Log("enemy");
                    b = true;
                    //hit.collider.transform.FindChild("Selected").gameObject.SetActive(true);
                    //selecting = true;
                    currentlySelected = hit.collider.gameObject;
                    //enemyHealthScript = currentlySelected.GetComponent<enemyHealth>();
                    //enemyhealth = enemyHealthScript.Health;

                }

            }
        }
    }

    void OnGUI()
    {
        if (currentlySelected == spider)
        {
            Debug.Log("shoooooooow me");
            GUI.Box(new Rect(1800, 50, 90, 20), "Health :" + health);
        }
    }

    IEnumerator Dead()
    {
        yield return new WaitForSeconds(2);
        spider.SetActive(false);
        Destroy(spider);
    }

    IEnumerator Move()
    {
        yield return new WaitForSeconds(2);
        move = true;
    }
}
