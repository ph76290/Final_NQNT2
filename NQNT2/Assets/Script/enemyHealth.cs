using UnityEngine;
using System.Collections;

public class enemyHealth : MonoBehaviour {

    public int health = 150;
    Bad_guy bad_guy;
    GameObject enemy = GameObject.Find("skeleton");
    Animation anim;
    public GameObject monObj;

    public int Health
    {
        get { return health; }
    }
    void Start()
    {
        anim = GetComponent<Animation>();
    }
    void ApplyDamage(int TheDamage)
    {
        health -= TheDamage;

        if (health <= 0)
        {
            health = 0;
            //enemy.GetComponent(Bad_guy).enabled = false;
            if(monObj)
                bad_guy = monObj.GetComponent<Bad_guy>();
            bad_guy.enabled = false;
            anim.Play("die");
            StartCoroutine(Dead());
        }
    }

    IEnumerator Dead()
    {
        yield return new WaitForSeconds(2);
        Destroy(gameObject);
    }
}
