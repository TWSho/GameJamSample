using UnityEngine;

public class CubeRotation : MonoBehaviour
{
    public float rotationSpeed = 50f; // ‰ñ“]‘¬“x

    // –ˆƒtƒŒ[ƒ€ŒÄ‚Î‚ê‚éŠÖ”
    void Update()
    {
        // Y²ü‚è‚É‰ñ“]‚·‚é
        transform.Rotate(0f, rotationSpeed * Time.deltaTime, 0f);
    }
}
