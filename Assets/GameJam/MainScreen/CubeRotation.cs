using UnityEngine;

public class CubeRotation : MonoBehaviour
{
    [SerializeField] float rotationSpeed = 50f; // ��]���x
    public float Rotate;
    void Update()
    {
        // Y������ɉ�]����
        transform.Rotate(0f, rotationSpeed * Time.deltaTime, 0f);
        Rotate = transform.rotation.y;
    }
}
