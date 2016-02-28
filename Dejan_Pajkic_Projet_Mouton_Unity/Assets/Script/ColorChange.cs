using UnityEngine;
using System.Collections;

public class ColorChange : MonoBehaviour {
    MeshRenderer mr;

	// Use this for initialization
	void Start () {
        mr = GetComponent<MeshRenderer>();
	
	}
	
	// Update is called once per frame
	void Update () {
        Color randomColor = new Color(Random.value, Random.value, Random.value);
        mr.material.color = randomColor;
	
	}
}
