using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectRotation : MonoBehaviour
{
    private void OnMouseDrag()
    {
        float x = Input.GetAxis("Mouse X") * 1;
        float y = Input.GetAxis("Mouse Y") * 1;

        transform.Rotate(Vector3.down, x, Space.World);
        transform.Rotate(Vector3.right, y, Space.World);
    }
}
