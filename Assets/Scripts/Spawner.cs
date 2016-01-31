using UnityEngine;
using System.Collections;

public class Spawner : MonoBehaviour {

    public GameObject box;
    float timeLeft = 30.0f;

    void Start () {
        InvokeRepeating("CreateBox", 3f, 1.5f);
	}

    void Update()
    {
        timeLeft -= Time.deltaTime;
        if (timeLeft < 0)
        {
            Application.LoadLevel("house");
        }
    }

    void CreateBox() {
        Instantiate(box, new Vector2(-1.98f, 0.00f), Quaternion.identity);
    }
}
