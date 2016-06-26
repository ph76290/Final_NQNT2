using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Slash_attack : MonoBehaviour {


    public Image cooldownImage;
    bool cooldown = true;
    bool b = false;
    public Animator anim;
    public int TheDamage = 40;
    float cpt = 5.0f;
    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetKeyDown("t") && PlayerInventory2.currentMana >= 30 && cooldown)
        {
            b = true;
            anim.Play("Slash_attack");
            cooldown = false;
            PlayerInventory2.currentMana -= 30;
            StartCoroutine(Appear());
        }
        if (cooldown == false)
        {
            cooldownImage.fillAmount -= 1.0f / cpt * Time.deltaTime;
        }
        else
            cooldownImage.fillAmount = 1f;
    }

    void OnTriggerEnter(Collider hit)
    {
        if (hit.gameObject.tag == "enemy" && b)
        {
            hit.transform.SendMessage("ApplyDamage", TheDamage, SendMessageOptions.DontRequireReceiver);
            b = false;
        }
    }
    IEnumerator Appear()
    {
        yield return new WaitForSeconds(5);
        cooldown = true;
    }
}
