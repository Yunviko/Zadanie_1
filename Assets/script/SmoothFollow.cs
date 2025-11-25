using UnityEngine;

public class SmoothFollow : MonoBehaviour
{
    public Transform player;
    public Vector3 offset;
    public float smoothSpeed = 2f;
    private Vector3 velocity= Vector3.zero;
    void Update()
    {
        Vector3 position = player.position + offset;
        transform.position = Vector3.SmoothDamp(transform.position, position, ref velocity, smoothSpeed);

    }
}
