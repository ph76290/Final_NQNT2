using UnityEngine;
using System.Collections;

public class script_cinematic : MonoBehaviour {

    public Animator anim;
    bool d = true;
    bool b2 = true;
    int n = 0;
    public Light l;
    public Light pointLight;
    bool b = false;

    // Use this for initialization
    void OnGUI ()
    {
        if (n == 0)
            GUI.Box(new Rect(900, 300, 400, 30), "Mage : Oh where are we please ??");
        else if (n == 1)
            GUI.Box(new Rect(400, 300, 700, 30), "Warrior : I don't know I was in my house and I don't remember how i have arrived here !");
        else if (n == 2)
        {
            GUI.Box(new Rect(900, 300, 700, 30), "Mage : It's really weird, this place looks like mystic !");
            anim.enabled = true;
            anim.speed = 0.3f;
        }
        else if (n == 3)
            GUI.Box(new Rect(400, 300, 700, 30), "Warrior : I agree with you. What is that ?");
        else if (n == 4)
            GUI.Box(new Rect(900, 300, 700, 30), "Mage : It's a kind of droid may be !");
        else if (n == 5)
            GUI.Box(new Rect(400, 300, 700, 30), "Warrior : I have never seen this where I come..");
        else if (n == 6)
            GUI.Box(new Rect(900, 300, 700, 30), "Mage : In my world there are a lot of robots, droid and so on..");
        else if (n == 7)
            GUI.Box(new Rect(400, 500, 700, 30), "Droid : ze ezndd ebbhss aazzzhvfz .. dzdz");
        else if (n == 8)
            GUI.Box(new Rect(400, 300, 700, 30), "Warrior : He has said something, i heard it !");
        else if (n == 9)
            GUI.Box(new Rect(900, 300, 700, 30), "Mage : Yes I have understood, he told me he has lost his master and we have to help the droid to find him !");
        else if (n == 10)
            GUI.Box(new Rect(400, 300, 700, 30), "Warrior : Ok good, ask him if he knows how we can leave this place and mainly back home !!");
        else if (n == 11)
        {
            GUI.Box(new Rect(900, 300, 700, 30), "Mage : zzd zsevs zezz cheh ?? dzdz");
        }
        else if (n == 12)
        {
            GUI.Box(new Rect(900, 250, 700, 30), "Mage : Heeeeeeelp meee ahahhhah");
            GUI.Box(new Rect(400, 450, 700, 30), "Warrior : Ohhhh What is it !!!");
            GUI.Box(new Rect(400, 500, 700, 30), "Droid : zzzzzzzzzzzznncejndzjjzdjzj dzdz !");
        }
        else if (n == 14)
        {
            GUI.Box(new Rect(900, 300, 700, 30), "Mage : What was that ?");
        }
            
        else if (n == 15)
            GUI.Box(new Rect(400, 300, 700, 30), "Warrior : I don't know but it was very frightening !");
        else if (n == 16)
            GUI.Box(new Rect(400, 500, 700, 30), "Droid : zdzdz hddzh yydusdbdzdzfvrezq zudbdeznnu dzdz ..");
        else if (n == 17)
            GUI.Box(new Rect(900, 300, 700, 30), "Mage : Oh he says that now we have the ability to merge in order to runaway from this place !");
        else if (n == 18)
            GUI.Box(new Rect(900, 300, 700, 30), "Mage : We have to take the droid with us until the exit, come on !!");


    }
	
    void Start()
    {
        p.Pause();
    }
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            n++;    
        }
        if (b2)
        {
            b2 = false;
            StartCoroutine(particleDown());
        }
        if (b)
        {
            pointLight.range = 500;
            l.intensity = 8;
            StartCoroutine(particleUP());
            
        }
        else
        {
            l.intensity = 1.4f;
            pointLight.range = 0;
        }
        if (d)
        {
            StartCoroutine(discuss());
            d = false;
        }
        
	}

    IEnumerator particleDown()
    {
        yield return new WaitForSeconds(40);
        b = true;
        b2 = false;
    }
    IEnumerator particleUP()
    {
        yield return new WaitForSeconds(2);
        b = false;
    }

    IEnumerator discuss()
    {
        yield return new WaitForSeconds(3.5f);
        n++;
        d = true;
    }
}
