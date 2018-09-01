using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinScript : MonoBehaviour {
    public GameObject nameitwhateveryouwant;
    public float spin = 50f;
	// Use this for initialization
	void Start () {
       
	}
	
	// Update is called once per frame
	void Update () {
        transform.Rotate(Vector3.right * Random.Range(200, 400) * Time.deltaTime);
        transform.Rotate(Vector3.back * Random.Range(40, 200) * Time.deltaTime);
        transform.Rotate(Vector3.up * Random.Range(-200, 200) * Time.deltaTime);
    }
}
