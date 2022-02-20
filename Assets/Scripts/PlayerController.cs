using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Vector3 moveDir = Vector3.forward;
    public float moveSpeed = 5f;

    private void Update()
    {
        transform.Translate(moveDir * moveSpeed * Time.deltaTime);
    }
}
