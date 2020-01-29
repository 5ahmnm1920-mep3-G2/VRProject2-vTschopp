using UnityEngine;

public class RotatePowerCell : MonoBehaviour
{
    void Update()
    {
        transform.Rotate(0, 1, 0, Space.World);
    }
}
