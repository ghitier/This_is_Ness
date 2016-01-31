using UnityEngine;
using System.Collections;

public class Movement_cube : MonoBehaviour {

    public float[] spawn_coords = new float[] { -1.98f, 0.00f};
    public float coords = 0.0f;
    public int direction = 0;

	void Update ()
    {
        if (direction == 0)
        { 
            transform.position = new Vector3(spawn_coords[0] + coords, spawn_coords[1], 0);
            coords += 0.015f;
            if (coords >= 4.2f)
            {
                direction++;
                coords = 0;
            }
        }
        if (direction == 1)
        {
            transform.position = new Vector3(spawn_coords[0] + 4.2f, spawn_coords[1] - coords, 0);
            coords = coords + 0.015f;
            if (coords >= 2.43f)
            {
                Destroy(gameObject);
            }
        }
    }
}
