using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public bool isPaused = false;
    public GameObject pauseButton;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //pauseButton = GameObject.FindGameObjectWithTag("PauseButton");
        this.gameObject.SetActive(isPaused);
    }

    // Update is called once per frame
    public void Unpause()
    {
        isPaused = false;
        this.gameObject.SetActive(isPaused);
        pauseButton.GetComponent<PauseButton>().Unpause();
    }

    public void Activate()
    {
        switch (isPaused)
        {
            case true:
                isPaused = false;
                this.gameObject.SetActive(isPaused);
               // pauseButton.GetComponent<PauseButton>().Pause();
                break;

            case false:
                isPaused = true;
                this.gameObject.SetActive(isPaused);
               // pauseButton.GetComponent<PauseButton>().Unpause();
                break;
        }
    }
}
