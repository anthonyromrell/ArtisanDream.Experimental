using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

[CreateAssetMenu]
public class LevelData : ScriptableObject
{
   public float LevelSpeed = 10;
   public AudioClip Song;
   public int CoinCount = 100;
   public Scene LevelScene;
   public int EnemyNumbers = 10;
}
