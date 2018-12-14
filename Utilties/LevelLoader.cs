using UnityEngine;
using UnityEngine.SceneManagement;

[CreateAssetMenu(menuName = "Utilities/Game LevelLoader")]
public class LevelLoader : ScriptableObject
{
    public void Load(Object scene)
    {
        var newScene = scene.name;
        SceneManager.LoadScene(newScene);
    }
}