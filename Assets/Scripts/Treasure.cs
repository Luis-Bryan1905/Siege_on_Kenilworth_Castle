using Unity.VisualScripting;
using UnityEngine;

public class Treasure : MonoBehaviour
{
    GameObject ScoreUI;
    int ScoreReward = 100;  
    Rigidbody rb;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        ScoreUI = GameObject.FindGameObjectWithTag("ScoreUI");
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Projectile"))
        {
            Debug.Log("Treasure Hit by player"); //debug to make sure medthod is called

            ScoreUI.GetComponent<Score>().AddPoint(ScoreReward);

            Destroy(gameObject); //Destroy Self
        }

        if (other.CompareTag("Block"))
        {
            rb = other.GetComponent<Rigidbody>();

            Vector3 vel = rb.linearVelocity; //get velocity of projectile at point of collision

            Debug.Log(other.name + "Velocity :" + vel); //debug to make sure method is called and velocity is correct

            if (vel.x > 1.0f || vel.y > 1.0f) //if touches projectile
            {
                Debug.Log("Treasure Hit" + vel); //debug to make sure medthod is called

                ScoreUI.GetComponent<Score>().AddPoint(ScoreReward);

                Destroy(gameObject); //Destroy Self
            }
        }


    }
}
