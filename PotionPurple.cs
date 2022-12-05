using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PotionPurple : MonoBehaviour
{
    // Lumi Vargas Moreno. POO. Tercera mecánica agregada: Poción que reacciona al contacto, al ser rozada, esta aumentará la vida del personaje.
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

private void OnCollisionEnter2D(Collision2D other) {
    if(other.gameObject.tag=="Jugador"){
         Efecto();
    }
}


    public void Efecto()
    {
        GameObject.FindGameObjectWithTag("Jugador").GetComponent<Jugador>().vidas +=10;
        Destroy(this.gameObject);
        Debug.Log("Recuperaste 1 de vida");
    }
}
