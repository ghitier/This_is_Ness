using UnityEngine;
using System.Collections;

public class checkList : MonoBehaviour {

    public GameObject A, B, C, D;
    checkList()
    {

    }

    public void check_done(int index)
    {
        if (index == 0)
        {
            A.SetActive(true);
        }
        else if (index == 1)
        {
            B.SetActive(true);
        }
        else if (index == 2)
        {
            C.SetActive(true);
        }
        else if (index == 3)
        {
            D.SetActive(true);
        }
    }

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
