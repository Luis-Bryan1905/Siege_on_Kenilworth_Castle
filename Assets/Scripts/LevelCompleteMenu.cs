using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelCompleteMenu : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    public void Activate()
    {
        this.gameObject.SetActive(true);
        Time.timeScale = 0f;
        Debug.Log("PAUSED: Time.timeScale = " + Time.timeScale.ToString());
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
