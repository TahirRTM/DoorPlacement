using UnityEngine;
using UnityEngine.InputSystem; // 🔁 Input System API

public class KeyRotateDoor : MonoBehaviour
{
    private bool isUpright = false;

    void Update()
    {
        if (Keyboard.current.rKey.wasPressedThisFrame && !isUpright)
        {
            transform.rotation = Quaternion.Euler(0f, transform.rotation.eulerAngles.y, 0f);
            isUpright = true;
            Debug.Log("Door rotated upright using Input System (R key).");
        }
    }
}
