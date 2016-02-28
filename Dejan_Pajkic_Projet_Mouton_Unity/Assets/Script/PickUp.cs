using UnityEngine;
using System.Collections;

public class PickUp : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

	}

    void OnTriggerEnter (Collider col)
    {
        if (col.tag == "Player")
        {
            Destroy(gameObject);
            col.GetComponent<Player>().Grow (); 
        }
    }
}
