using UnityEngine;
using System.Collections;

public class HouseTriggers : MonoBehaviour {

    bool inside_box = false;
    public Sprite state1;
    public Sprite state2;
    private float lastAction;

    void    OnTriggerEnter2D (Collider2D other)
    {
        inside_box = true;
        lastAction = Time.time;
    }

    void OnTriggerExit2D(Collider2D other)
    {
        inside_box = false;
    }

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Time.time - lastAction > 1 && inside_box && Input.GetButton("Action"))
        {
            if (this.GetComponent<SpriteRenderer>().sprite == state1)
                this.GetComponent<SpriteRenderer>().sprite = state2;
            else
                this.GetComponent<SpriteRenderer>().sprite = state1;
            lastAction = Time.time;
        }
    }
}
