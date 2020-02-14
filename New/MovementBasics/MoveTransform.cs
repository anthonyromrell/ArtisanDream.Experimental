using UnityEngine;
using UnityEngine.Serialization;

public class MoveTransform : MonoBehaviour
{
    [FormerlySerializedAs("Speed")] public float speed = 3;
    private Vector3 startPoint;

    private void Start()
    {
        startPoint = transform.position;
    }

    private void Update()
    {
        transform.Translate(speed*Time.deltaTime,0,0);
    }

    public void Restart()
    {
        transform.position = startPoint;
    }

    private void OnBecameInvisible()
    {
        Restart();
    }
}