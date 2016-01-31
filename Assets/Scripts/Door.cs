using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class Door : MonoBehaviour {

    void    OnTriggerEnter2D (Collider2D other)
    {
        if (other.name == "Character")
            SceneManager.LoadScene("Work");
    }

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
