using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class HealSpell : MonoBehaviour {

    public Image cooldownImage;
    public GameObject colliderFlame;
    private PlayerControl playerstats;
    float cpt_heal = 5.0f;
    bool cooldown = true;

    void Start()
    {
        colliderFlame.SetActive(false);
        playerstats = GameObject.Find("Health").GetComponent<PlayerControl>();
    }

    // Update is called once per frame
    void Update()
    {

        if (GameInProgress.b1)
        {
            if (Input.GetKeyDown("h") && PlayerInventory.currentMana >= 30 && cooldown)
            {
                PlayerInventory.currentHealth += 40;
                cooldown = false;
                PlayerInventory.currentMana -= 20;
                StartCoroutine(Appear());


            }
            if (cooldown == false)
            {
                cooldownImage.fillAmount -= 1.0f / cpt_heal * Time.deltaTime;
            }
            else
                cooldownImage.fillAmount = 1f;
        }
        else
            cooldownImage.fillAmount = 0f;
    }
    IEnumerator Appear()
    {

        colliderFlame.SetActive(true);
        yield return new WaitForSeconds(4);
        colliderFlame.SetActive(false);
        yield return new WaitForSeconds(10);
        cooldown = true;
    }
}
