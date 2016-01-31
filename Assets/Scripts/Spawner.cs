using UnityEngine;
using System.Collections;

public class Spawner : MonoBehaviour {

    public GameObject box;

    void Start () {
        InvokeRepeating("CreateBox", 3f, 1.5f);
	}
	
    void CreateBox() {
        Instantiate(box, new Vector2(-1.98f, 0.00f), Quaternion.identity);
    }
}
