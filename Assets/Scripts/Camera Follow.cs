using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    
    GameObject gb; 

    public float minDistance = 0.0f; // Minimum distance the camera can be from the target
    public float maxDistance = 26.0f; // Minimum distance the camera can be from the target
    float X;
    bool followActive = false;


    public void Grabscore()
    {
        gb = GameObject.FindGameObjectWithTag("Projectile");
    }


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void Start()
    {
        Grabscore();
    }

    // Update is called once per frame
    void Update()
    {

        if (gb != null)
        {
            if (gb.gameObject.GetComponent<score>().IsPressed == true && gb.gameObject.GetComponent<score>().active == true)
            {
                followActive = false;
            }
            else
            {
                followActive = true;
            }

            switch (followActive)
            {
                    case true:
                        this.transform.position = new Vector3(gb.transform.position.x, transform.position.y, transform.position.z);
                        break;

                    case false:
                        this.transform.position = new Vector3(minDistance, transform.position.y, transform.position.z);
                    break;
            }
        }
        else
        {
            Grabscore();
        }








    }
}
