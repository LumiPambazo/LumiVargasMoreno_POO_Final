using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomb : MonoBehaviour
{
    
    // Lumi Vargas Moreno. POO. Segunda mecánica agregada: Bomba que reacciona al contacto, al ser rozada, esta reducirá la vida del personaje.
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

private void OnCollisionEnter2D(Collision2D other) 
{
    if(other.gameObject.tag=="Jugador")
    {
        Efecto();
    }
}
    public void Efecto()
    {
        GameObject.FindGameObjectWithTag("Jugador").GetComponent<Jugador>().vidas -= 1;
        Destroy(this.gameObject);
    }
}
