using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlayerControl : MonoBehaviour
{
    public GameObject HealthBar;
    public static int health = 100;
    public static int money = 0;
    
    // Use this for initialization

    /*void ApplyDamage(int TheDamage)
    {
        //health -= Damage;

        if (health <= 0)
        {
            Dead();
        }

    }*/
    
    void Dead()
    {

        Debug.Log("Player Died");
    }
    void OnGUI()
    {
            GUI.Box(new Rect(60, 50, 90, 20), "Health :" + health);
            GUI.Box(new Rect(60, 75, 90, 30), "Gold :" + money);
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (health <= 0)
        {
            health = 0;
            Debug.Log("Player died !");
        }
    }
}
