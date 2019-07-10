using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextoFlotane : MonoBehaviour {
    public Camera camara;
    public float tiempoDeVida = 1f;
    public Vector3 offSet = new Vector3(0, 1, 0);
	// Use this for initialization
	void Start () {
        camara = GameObject.Find("FirstPersonCharacter").GetComponent<Camera>();
        Destroy(gameObject, tiempoDeVida);
        transform.localPosition += offSet;
    }
	
	// Update is called once per frame
	void Update () {
       
        transform.LookAt(transform.position + camara.transform.rotation *
            Vector3.forward, camara.transform.rotation * Vector3.up);
	}
}
