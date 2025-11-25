using UnityEngine;

public class SimpleCamera : MonoBehaviour
{
 public Transform player;
    public Vector3 offset;
    public float smoothSpeed = 0.1f;
    void Update()
    {
        Vector3 position= player.position + offset;
        Vector3 smoothPosition= Vector3.Lerp(player.position, position, smoothSpeed);
        transform.position = smoothPosition;
        
    }
}
