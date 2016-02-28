using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {
    public float speed;
    public float growValue = 1;
    public float growDevalue = 1; // valeur de dégrossissement
    Rigidbody rb;
    public GameObject laine, tete, oreilleg, oreilled;      //permet de faire changer la couleur de la laine, la tête, et tout ce que je veux
    
    

    // Use this for initialization
    void Start () {
       
        rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 force = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        rb.AddForce(force * speed);
	
	}

    public void Grow () {
        transform.localScale += Vector3.one * growValue;
        Color randomColor = new Color(Random.value, Random.value, Random.value);        //permet de faire changer la couleur de la laine
        laine.GetComponent<MeshRenderer>().material.color = randomColor;                    

        Color randomColor2 = new Color(Random.value, Random.value, Random.value);           // permet de faire changer la couleur de la tête
        tete.GetComponent<MeshRenderer>().material.color = randomColor2;

        Color randomColor3 = new Color(Random.value, Random.value, Random.value);           // permet de faire changer la couleur de la tête
        oreilleg.GetComponent<MeshRenderer>().material.color = randomColor3;

        Color randomColor4 = new Color(Random.value, Random.value, Random.value);           // permet de faire changer la couleur de la tête
        oreilled.GetComponent<MeshRenderer>().material.color = randomColor4;
    }


    public void Degrow() // fonction degrow
    {
        transform.localScale -= Vector3.one * growDevalue;
        Color randomColor = new Color(Random.value, Random.value, Random.value);        //permet de faire changer la couleur de la laine
        laine.GetComponent<MeshRenderer>().material.color = randomColor;

        //Color randomColor2 = new Color(Random.value, Random.value, Random.value);           // permet de faire changer la couleur de la tête
        //tete.GetComponent<MeshRenderer>().material.color = randomColor2;
    }
}
