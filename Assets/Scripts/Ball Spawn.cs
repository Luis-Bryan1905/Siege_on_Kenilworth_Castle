using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class BallSpawn : MonoBehaviour
{

    public int StageAmount;
    int ProjectileAmount;
    public GameObject ProjectilePrefab;   // prefab assigned in inspector
    GameObject Projectile;
    GameObject Camera;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Camera = GameObject.FindGameObjectWithTag("MainCamera");
        ProjectileAmount += StageAmount;

        Check();
    }

    // Update is called once per frame
    public void Check()
    {
        Projectile = GameObject.FindGameObjectWithTag("Projectile");

        if (Projectile == null)
        {
            Spawn();
        }
    }

    public void Spawn()
    {
        Instantiate(ProjectilePrefab, this.transform.position, Quaternion.identity);
        Camera.GetComponent<CameraFollow>().GrabBall();
    }

}
