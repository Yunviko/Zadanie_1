using UnityEngine;

public class DeadZoneCamera : MonoBehaviour
{
    public Transform player;
    public Vector2 deadZoneSize = new Vector2(2f, 2f);
    public float smoothSpeed = 2f;

    void LateUpdate()
    {
        Vector3 position = transform.position;
        Vector3 diff = player.position - transform.position;

        if (Mathf.Abs(diff.x) > deadZoneSize.x)
            position.x = Mathf.Lerp(position.x, player.position.x, Time.deltaTime * smoothSpeed);

        if (Mathf.Abs(diff.y) > deadZoneSize.y)
            position.y = Mathf.Lerp(position.y, player.position.y, Time.deltaTime * smoothSpeed);

        transform.position = new Vector3(position.x, position.y, transform.position.z);
    }
}