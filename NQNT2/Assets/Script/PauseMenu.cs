using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PauseMenu : MonoBehaviour {
    GameObject Pausedmenu;
    bool paused;
    bool muted;
    Rotation_cam script_rotation;
    public Text mutetext;
	// Use this for initialization
	void Start ()
    {
        paused = false;
        Pausedmenu = GameObject.Find("PausedMenu");
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            paused = !paused;
        }
        if (paused)
        {
            Pausedmenu.SetActive(true);
            Time.timeScale = 0;
            }
            else if (!paused)
            {
                Pausedmenu.SetActive(false);
                Time.timeScale = 1;
            }
            if (muted)
            {
                AudioListener.volume = 0;
                mutetext.text = "Unmute";
            }
            else if (!muted)
            {
                AudioListener.volume = 1;
                mutetext.text = "Mute";
            }
    }
    public void Resume()
    {
        paused = false;
    }
    public void MainMenu()
    {
        //Application.LoadLevel("Menu");
    }
    public void Save()
    {
        //PlayerPrefs.SetInt("currentscenesave", Application.loadedLevel);
    }
    public void Load()
    {
        //Application.LoadLevel(PlayerPrefs.GetInt("currentscenesave"));
    }
    public void Mute()
    {
        muted = !muted;
    }
   
}
