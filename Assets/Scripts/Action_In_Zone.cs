using UnityEngine;
using System.Collections;

public class Action_In_Zone : MonoBehaviour {

    public GameObject box;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Box_Tag"))
            if (Input.GetKey("e"))
            {
                Destroy(other.gameObject);
                Invoke("Create_new_box", 0.0f);
            }
    }

    void Create_new_box()
    {
        Instantiate(box, new Vector2(-1.98f, 0.00f), Quaternion.identity);
    }
}
