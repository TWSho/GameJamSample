using UnityEngine;

public class CubeRotation : MonoBehaviour
{
    public float rotationSpeed = 50f; // 回転速度

    // 毎フレーム呼ばれる関数
    void Update()
    {
        // Y軸周りに回転する
        transform.Rotate(0f, rotationSpeed * Time.deltaTime, 0f);
    }
}
