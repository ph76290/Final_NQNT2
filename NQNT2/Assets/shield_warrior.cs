using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class shield_warrior : MonoBehaviour
{
    float cpt = 5.0f;
    public Image cooldownImage;
    bool cooldown = true;
    bool b = false;
    public Animator anim;
    public GameObject shield;
    // Use this for initialization
    void Start()
    {
        shield.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("b") && PlayerInventory2.currentMana >= 30 && cooldown)
        {
            shield.SetActive(true);
            PlayerInventory2.currentArmor += 30;
            StartCoroutine(Armor());
            b = true;
            anim.Play("Power_up");
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

    IEnumerator Appear()
    {
        yield return new WaitForSeconds(5);
        shield.SetActive(false);
        cooldown = true;
    }

    IEnumerator Armor()
    {
        
        yield return new WaitForSeconds(7);
        PlayerInventory2.currentArmor -= 30;
    }
}
