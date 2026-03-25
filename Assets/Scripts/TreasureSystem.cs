using UnityEngine;

public class TreasureSystem : MonoBehaviour
{

    public int treasureAmount = 0; // Amount of treasure available
    public int CurrentTreasure = 0; // Amount of treasure collected by the player
    public GameObject LevelCompleteMenu;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddTreasure()
    {
        treasureAmount++;
        CurrentTreasure++;
    }

    public void TreasureDestroyed()
    {
        CurrentTreasure--;

        if (CurrentTreasure <= 0)
        {
            Debug.Log("All Treasure Collected!"); //debug to make sure method is called
            GameObject.FindGameObjectWithTag("PauseButton").SetActive(false);
            LevelCompleteMenu.GetComponent<LevelCompleteMenu>().Activate();
        }
    }
}
