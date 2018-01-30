using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float turnSpeed = 4.0f;      // Speed of camera turning when mouse moves in along an axis

    private Vector3 mouseOrigin;    // Position of cursor when mouse dragging starts
    private bool isRotating;    // Is the camera being rotated?

    void Update()
    {
        //transform.Rotate(0, x, 0);
        //transform.Translate(y, 0, z);

       
        // Get the left mouse button
        if (Input.GetMouseButtonDown(0))
        {
             // Get mouse origin
             mouseOrigin = Input.mousePosition;
             isRotating = true;
        }

        // Disable movements on button release
        if (!Input.GetMouseButton(0)) isRotating = false;

        // Rotate camera along X and Y axis
        if (isRotating)
        {
            Vector3 pos = Camera.main.ScreenToViewportPoint(Input.mousePosition - mouseOrigin);

            transform.RotateAround(transform.position, transform.right, -pos.y * turnSpeed);
            transform.RotateAround(transform.position, Vector3.up, pos.x * turnSpeed);
        }

        if (transform.rotation.x >= 45 && transform.rotation.y >= 0)
            transform.rotation = Quaternion.Euler(45, 0, 0);
        
    }
}