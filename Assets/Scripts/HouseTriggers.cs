using UnityEngine;

public class HouseTriggers : MonoBehaviour {

    bool inside_box = false;
    public Sprite state1;
    public Sprite state2;
    public int type;
    private float lastAction;
    public checkList List;

    void    OnTriggerEnter2D (Collider2D other)
    {
        inside_box = true;
        lastAction = Time.time;
    }

    void OnTriggerExit2D(Collider2D other)
    {
        inside_box = false;
    }

    public HouseTriggers()
    {

    }
    // Use this for initialization
    void Start () {
	
	}
	// Update is called once per frame
	public void Update () {
        if (Time.time - lastAction > 1 && inside_box && Input.GetButton("Action"))
        {
            List.check_done(type);
            if (this.GetComponent<SpriteRenderer>().sprite == state1)
                this.GetComponent<SpriteRenderer>().sprite = state2;
            else
                this.GetComponent<SpriteRenderer>().sprite = state1;
            lastAction = Time.time;
        }
    }
}
