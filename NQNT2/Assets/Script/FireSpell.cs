using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class FireSpell : MonoBehaviour {

    public Image cooldownImage;
    public GameObject colliderFlame;
    private PlayerControl playerstats;
    float cpt_fire = 5.0f;
    bool cooldown = true;
    
	void Start ()
    {
        colliderFlame.SetActive(false);
        playerstats = GameObject.Find("Health").GetComponent<PlayerControl>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        
        if (GameInProgress.b1)
        {
            if (Input.GetKeyDown("f") && PlayerInventory.currentMana >= 30 && cooldown)
            {
                cooldown = false;
                PlayerInventory.currentMana -= 30;
                StartCoroutine(Appear());


            }
            if (cooldown == false)
            {
                cooldownImage.fillAmount -= 1.0f / cpt_fire * Time.deltaTime;
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
        yield return new WaitForSeconds(2);
        colliderFlame.SetActive(false);
        yield return new WaitForSeconds(5);
        cooldown = true;
    }
}
