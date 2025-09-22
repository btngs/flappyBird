using UnityEngine;

public class Pipe : MonoBehaviour
{
    private float speed = 0.5f;

    private void Update()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;
    }
}
