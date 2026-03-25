using UnityEngine;

public class FinalScore : MonoBehaviour
{

    public GameObject ScoreText;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.GetComponent<UnityEngine.UI.Text>().text = ScoreText.GetComponent<UnityEngine.UI.Text>().text;
    }
}
