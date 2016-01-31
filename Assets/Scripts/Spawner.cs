using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Spawner : MonoBehaviour {

    public static int change_map = 0;
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
            SceneManager.LoadScene("house");
        }
    }

    void CreateBox() {
        Instantiate(box, new Vector2(-1.98f, 0.00f), Quaternion.identity);
    }
}
