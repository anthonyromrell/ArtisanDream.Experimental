using UnityEngine;

public class MoveTransform : MonoBehaviour
{
    public float Speed = 3;
    private Vector3 startPoint;

    private void Start()
    {
        startPoint = transform.position;
    }

    private void Update()
    {
        transform.Translate(Speed*Time.deltaTime,0,0);
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