using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

    public float    speed;
    public Animator anim_control;

	// Use this for initialization
	void Start () {
        anim_control.SetBool("walk", false);
	}
	
	// Update is called once per frame
    void Update () {
        Vector2 axis = new Vector2();
        axis.x = Input.GetAxis("Horizontal");
        axis.y = Input.GetAxis("Vertical");
        if (Mathf.Abs(axis.x) >= 0.01F || Mathf.Abs(axis.y) >= 0.01F)
            anim_control.SetBool("walk", true);
        else
            anim_control.SetBool("walk", false);
        transform.Translate(axis * Time.deltaTime * speed);
    }
}
