using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vida : MonoBehaviour {
    public Vida padreRef; //4
    public float valor = 100;
    public float multiplicadorDaño = 1.0f; //4
    public GameObject textoFlotantePrefab;
    public float dañoTotal;//4
   
	// Use this for initialization
	void Start () {	
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void RecibirDaño(float daño)
    {    
        //4 inicia
        daño *= multiplicadorDaño;
        if (padreRef != null)
        {
            padreRef.RecibirDaño(daño);
            return;
        }
        //4 fin
        valor -= daño;
        dañoTotal = daño;
        if(valor>=0) MostrarTextoFlotante(); //4
        if (valor < 0)
        {
            valor = 0;
            MostrarTextoFlotante(); //4
        }
    }

    //4 inicia
    void MostrarTextoFlotante()
    {
        var go =Instantiate(textoFlotantePrefab, transform.position, Quaternion.identity, transform);
        //go.GetComponent<TextMesh>().text = valor.ToString();
        go.GetComponent<TextMesh>().text = dañoTotal.ToString();
    }
    //4 fin
}
