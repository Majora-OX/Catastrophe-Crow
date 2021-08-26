using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtToggle : MonoBehaviour 
{

    public bool looking = false;
    public Transform lookat;
    public float lookatspeed;
    public Transform lookat2;
    public bool direction;
    public Transform lookatused;
	private void Update()
    {
        if (Input.GetKeyDown("q"))
        {
            looking = !looking;
        }
        if (looking == true) {
            if (!direction) { lookatused.position = lookat.position; } else { lookatused.position = lookat2.position; }
            // Determine which direction to rotate towards
            Vector3 targetDirection = lookatused.position - (transform.position);

        // The step size is equal to speed times frame time.
        float singleStep = lookatspeed * Time.deltaTime;

        // Rotate the forward vector towards the target direction by one step
        Vector3 newDirection = Vector3.RotateTowards(transform.forward, targetDirection, singleStep, 0.0f);

        // Draw a ray pointing at our target in
        Debug.DrawRay(transform.position, newDirection, Color.red);

        // Calculate a rotation a step closer to the target and applies rotation to this object
        transform.rotation = Quaternion.LookRotation(newDirection);
        }
    }
}
