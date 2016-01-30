using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour {
        void OnMouseDown() {
            SceneManager.LoadScene("house");
    }
}
