using UnityEngine;
using UnityEngine.UI;

public class BallText : MonoBehaviour
{
    Text ballText;
    public int balls;

    GameObject Sling;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Sling = GameObject.FindGameObjectWithTag("Sling");
        //balls = Sling.GetComponent<BallSpawn>().ProjectileAmount;
        ballText = this.GetComponent<Text>();
        balls = Sling.GetComponent<BallSpawn>().StageAmount;
        ballText.text = "Balls: " + balls.ToString();
    }

    public void UpdateText()
    {
        ballText.text = "Balls: " + Sling.GetComponent<BallSpawn>().ProjectileAmount.ToString();
    }

}
