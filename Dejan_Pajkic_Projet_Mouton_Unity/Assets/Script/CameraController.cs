using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {
    public GameObject target;
    public Vector3 offset;
    public float speed = 1;


	// Use this for initialization
	void Start () {
        offset = transform.position;
	
	}
	
	// Update is called once per frame
	void Update () {
        transform.position = Vector3.Lerp (transform.position, target.transform.position + offset, speed * Time.deltaTime);
       // transform.position = target.transform.position + offset;
        transform.LookAt(target.transform);
	
	}
}
