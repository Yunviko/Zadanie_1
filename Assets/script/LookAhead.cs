using UnityEngine;

public class LookAhead : MonoBehaviour
{
    public Transform player;
    public float smoothTime = 1f;
    public float lookAheadDistance = 4f;

    private Vector3 velocity = Vector3.zero;

    void LateUpdate()
    {
        float direction = Input.GetAxisRaw("Horizontal");

        Vector3 targetPosition = player.position + new Vector3(direction * lookAheadDistance, 0, -10);
    
        transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref velocity, smoothTime);
    }
}