using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using Object = UnityEngine.Object;

[CreateAssetMenu(menuName = "Utilities/Game LevelLoader")]
public class LevelLoader : ScriptableObject
{
    public enum LoadTypes
    {
        LoadScene,
        LoadSceneAdditive,
        LoadSceneAsync
    }

    public LoadTypes LoadType;

    public void Load(Object scene)
    {
        var newScene = scene.name;

        switch (LoadType)
        {
            case LoadTypes.LoadScene:
                SceneManager.LoadScene(newScene);
                break;
            case LoadTypes.LoadSceneAsync:
                SceneManager.LoadSceneAsync(newScene);
                break;
            case LoadTypes.LoadSceneAdditive:
                SceneManager.LoadScene(newScene, LoadSceneMode.Additive);
                break;
            
        }
    }
}