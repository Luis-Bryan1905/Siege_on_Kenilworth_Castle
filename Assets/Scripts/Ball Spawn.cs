using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class BallSpawn : MonoBehaviour
{
    GameObject BallUI;
    public int StageAmount;
    public int ProjectileAmount = 0;
    public GameObject ProjectilePrefab;   // prefab assigned in inspector
    public GameObject GameOverMenu;
    GameObject Projectile;
    GameObject Camera;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        BallUI = GameObject.FindGameObjectWithTag("BallUI");
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
        ProjectileAmount -= 1;
        BallUI.GetComponent<BallText>().UpdateText();

        if (ProjectileAmount > 0)
        {
            Instantiate(ProjectilePrefab, this.transform.position, Quaternion.identity);
            Camera.GetComponent<CameraFollow>().Grabscore();
        }
        else if (ProjectileAmount == 0)
        {
            Debug.Log("GAME OVER: No more projectiles left");
            GameObject.FindGameObjectWithTag("PauseButton").SetActive(false);
            GameOverMenu.GetComponent<GameOverMenu>().Activate();
        }

    }

}
