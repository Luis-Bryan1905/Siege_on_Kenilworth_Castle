using UnityEngine;
using UnityEngine.UI;

public class PauseButton : MonoBehaviour
{

    public bool isPaused;
    GameObject PauseMenu;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        PauseMenu = GameObject.FindGameObjectWithTag("PauseMenu");
        isPaused = false;
    }

    void Update()
    {

        switch (isPaused)
        {
            case true:
                Pause();
                Debug.Log("PAUSED: Time.timeScale = " + Time.timeScale.ToString());
                break;

            case false:
                Unpause();
                Debug.Log("NOT PAUSED: Time.timeScale = " + Time.timeScale.ToString());
                break;
        }
    }

    public void Unpause()
    {
        isPaused = false; 
        Time.timeScale = 1f;
        Debug.Log("NOT PAUSED: Time.timeScale = " + Time.timeScale.ToString());
        this.gameObject.SetActive(true);
    }

    public void Pause()
    {
        isPaused = true;
        Time.timeScale = 0f;
        Debug.Log("PAUSED: Time.timeScale = " + Time.timeScale.ToString());
        PauseMenu.GetComponent<PauseMenu>().Activate();
        this.gameObject.SetActive(false);
    }
}
