using JetBrains.Annotations;
using Unity.VectorGraphics;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleScreen : MonoBehaviour
{

    // Update is called once per frame
    public void LoadLevel(string scene)
    {
        SceneManager.LoadScene(scene);
    }
}
