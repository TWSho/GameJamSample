using UnityEngine;

public class CubeRotation : MonoBehaviour
{
    [SerializeField] float rotationSpeed = 50f; // ‰ñ“]‘¬“x
    public float Rotate;
    void Update()
    {
        // YŽ²Žü‚è‚É‰ñ“]‚·‚é
        transform.Rotate(0f, rotationSpeed * Time.deltaTime, 0f);
        Rotate = transform.rotation.y;
    }
}
