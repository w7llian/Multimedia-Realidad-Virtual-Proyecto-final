using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LogicaJugador : MonoBehaviour {
    public Vida vida;
    public bool Vida0 = false;
    [SerializeField] private Animator animadorPerder; //4 ??


    public Puntaje puntaje; //4


    // Use this for initialization
    void Start () {
        vida = GetComponent<Vida>();
	}
	
	// Update is called once per frame
	void Update () {
        RevisarVida();

       
       
    }

    void RevisarVida()
    {
        
        if (Vida0) return;
        if(vida.valor <= 0)
        {
            AudioListener.volume = 0f; //4
            animadorPerder.SetTrigger("Mostrar");//4
            Vida0 = true;
            Invoke("ReiniciarJuego", 3f);
        }
    }

    void ReiniciarJuego()
    {
        AudioListener.volume = 1f; //4
        puntaje.valor = 0;//4
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

   //4 Inicia
    private void OnTriggerStay(Collider other)
    {
        
        if (other.gameObject.tag == "Enemigo")
        {
            gameObject.GetComponent<AudioSource>().volume = 0f;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Enemigo")
        {
            gameObject.GetComponent<AudioSource>().volume = 1f;
        }
    }
    //4 Fin
    
}

