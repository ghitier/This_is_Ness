using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

    public float    speed = 2.0f;
    public Animator anim_control;

	// Use this for initialization
	void Start () {
        anim_control.SetBool("walk", false);
	}
	
	// Update is called once per frame
    void Update () 
	{
        if (Mathf.Abs(Input.GetAxis("Horizontal")) >= 0.05 || Mathf.Abs(Input.GetAxis("Vertical")) >= 0.05)
            anim_control.SetBool("walk", true);
        else
            anim_control.SetBool("walk", false);
        float xPos = Input.GetAxis ("Horizontal") * Time.deltaTime * speed;
		float yPos = Input.GetAxis ("Vertical") * Time.deltaTime * speed;
		Vector3 position = transform.position;
		position.x += xPos;
		position.y += yPos; 
		transform.position = position;

		if (xPos != 0 || yPos != 0) {
			float heading = Mathf.Atan2 (yPos, xPos); 
			transform.rotation = Quaternion.Euler (0f, 0f, heading * Mathf.Rad2Deg);
		}

    }
}
