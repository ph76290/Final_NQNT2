using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TimeSpell : MonoBehaviour
{
    public Image cooldownImage;
    public GameObject colliderTime;
    private PlayerControl playerstats;
    float cpt_time = 5.0f;
    bool cooldown = true;

    void Start()
    {
        colliderTime.SetActive(false);
        playerstats = GameObject.Find("Health").GetComponent<PlayerControl>();
    }

    // Update is called once per frame
    void Update()
    {
        if (GameInProgress.b1)
        {
            if (Input.GetKeyDown("t") && PlayerInventory.currentMana >= 30 && cooldown)
            {
                cooldown = false;
                PlayerInventory.currentMana -= 30;
                StartCoroutine(Appear());
                /*Debug.Log("it works");
                Spell.SetActive(true);
                Appear();
                Spell.SetActive(false);*/
            }
            if (cooldown == false)
            {
                cooldownImage.fillAmount -= 1.0f / cpt_time * Time.deltaTime;
            }
            else
                cooldownImage.fillAmount = 1f;
        }
        else
            cooldownImage.fillAmount = 0f;
    }
    IEnumerator Appear()
    {

        colliderTime.SetActive(true);
        yield return new WaitForSeconds(1);
        colliderTime.SetActive(false);
        yield return new WaitForSeconds(5);
        cooldown = true;


    }
}
