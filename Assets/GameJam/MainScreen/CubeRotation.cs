using UnityEngine;

public class CubeRotation : MonoBehaviour
{
    public float rotationSpeed = 50f; // ��]���x

    // ���t���[���Ă΂��֐�
    void Update()
    {
        // Y������ɉ�]����
        transform.Rotate(0f, rotationSpeed * Time.deltaTime, 0f);
    }
}
