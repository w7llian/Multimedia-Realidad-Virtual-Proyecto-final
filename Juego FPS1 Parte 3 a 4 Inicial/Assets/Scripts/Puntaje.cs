﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Puntaje : MonoBehaviour {
    public float valor;
    public Puntaje puntaje;
    public Text texto;

    // Use this for initialization
    void Start () {
        valor = 0;
        
	}
	
	// Update is called once per frame
	void Update () {
        texto.text = "Puntaje:" + puntaje.valor;


    }



}
