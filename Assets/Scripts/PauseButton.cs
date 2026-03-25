using UnityEngine;
using UnityEngine.UI;

public class PauseButton : MonoBehaviour
{

    public bool isPaused;
    public bool TimeScaleDebug;
    public GameObject PauseMenu;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //PauseMenu = GameObject.FindGameObjectWithTag("PauseMenu");
        isPaused = false;
    }

    void Update()
    {

        switch (isPaused)
        {
            case true:
                Pause();

                if (TimeScaleDebug == true)
                {
                    Debug.Log("PAUSED: Time.timeScale = " + Time.timeScale.ToString());
                }

                break;

            case false:
                Unpause();

                if (TimeScaleDebug == true)
                {
                    Debug.Log("NOT PAUSED: Time.timeScale = " + Time.timeScale.ToString());
                }

                break;
        }
    }

    public void Unpause()
    {
        isPaused = false; 
        Time.timeScale = 1f;

        if (TimeScaleDebug == true)
        {
            Debug.Log("NOT PAUSED: Time.timeScale = " + Time.timeScale.ToString());
        }

        this.gameObject.SetActive(true);
    }

    public void Pause()
    {
        isPaused = true;
        Time.timeScale = 0f;

        if (TimeScaleDebug == true)
        {
            Debug.Log("PAUSED: Time.timeScale = " + Time.timeScale.ToString());
        }

        PauseMenu.GetComponent<PauseMenu>().Activate();
        this.gameObject.SetActive(false);
    }
}
