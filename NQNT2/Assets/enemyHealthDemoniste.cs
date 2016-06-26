using UnityEngine;
using System.Collections;
using System.Resources;
using System;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class enemyHealthDemoniste : MonoBehaviour
{

    public GameObject HPMANACanvas;
    public Text hpText;
    public Image hpImage;
    public static bool move = true;
    bool b = false;
    int enemyhealth;
    private enemyHealth enemyHealthScript;
    public static GameObject currentlySelected;
    private Vector3 mouseDownPoint;
    private static bool selecting;
    RaycastHit hit;
    private float raycastLength = 500f;
    private MouseSelection mouse;
    public int maxHealth = 500;
    private int health = 0;
    int copyHealth;
    Demoniste mutant;
    Animation anim;
    public GameObject monObj;

    public int Health
    {
        get { return copyHealth; }
    }
    void Start()
    {
        health = maxHealth;
        anim = GetComponent<Animation>();
    }
    void ApplyDamage(int TheDamage)
    {
        health -= TheDamage;
        Debug.Log("aie");
        copyHealth = health;
        if (health <= 0)
        {
            health = 0;
            //enemy.GetComponent(Bad_guy).enabled = false;
            if (monObj)
                mutant = monObj.GetComponent<Demoniste>();
            mutant.enabled = false;
            anim.Play("die");
            StartCoroutine(Dead());
        }
    }

    void UpdateHPBar()
    {
        hpText.text = (health + "/" + maxHealth);
        float fillAmountHP = health / maxHealth;
        hpImage.fillAmount = fillAmountHP;
    }

    void Update()
    {
        if (health > maxHealth)
            health = maxHealth;
        UpdateHPBar();
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
                    Debug.Log(enemyhealth);

                }

            }
        }
    }

    void OnGUI()
    {
        if (currentlySelected == monObj)
        {
            Debug.Log("shoooooooow me");
            GUI.Box(new Rect(1800, 50, 90, 20), "Health :" + health);
        }
    }

    IEnumerator Dead()
    {
        yield return new WaitForSeconds(2);
        Destroy(gameObject);
    }

    IEnumerator Move()
    {
        yield return new WaitForSeconds(1.5f);
        move = true;
    }
}
