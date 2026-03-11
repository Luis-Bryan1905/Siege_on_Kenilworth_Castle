using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    
    public GameObject gb; 

    public float minDistance = 0.0f; // Minimum distance the camera can be from the target
    public float maxDistance = 26.0f; // Minimum distance the camera can be from the target
    float X;
    bool followActive = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (gb.gameObject.GetComponent<Ball>().IsPressed == true)
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
}
