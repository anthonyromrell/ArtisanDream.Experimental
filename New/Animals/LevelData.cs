using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;
using UnityEngine.Serialization;

[CreateAssetMenu]
public class LevelData : ScriptableObject
{
   [FormerlySerializedAs("LevelSpeed")] public float levelSpeed = 10;
   [FormerlySerializedAs("Song")] public AudioClip song;
   [FormerlySerializedAs("CoinCount")] public int coinCount = 100;
   [FormerlySerializedAs("LevelScene")] public Scene levelScene;
   [FormerlySerializedAs("EnemyNumbers")] public int enemyNumbers = 10;
}
