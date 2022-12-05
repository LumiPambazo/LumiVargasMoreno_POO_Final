using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

/*
Alumna: Lumi Vargas Moreno
Asignatura: Programacion Orientada a Objetos
Este script se enarga de crear un controlador de personaje completo para un juego de plataforma con movimientos y animaciones basicas aquí se agregó
la mecánica de juego que hace que el usuario pueda dar mayor altura al salto, presionando dos o más veces la barra de espacio.
*/
//Profe tenga piedad, no ejerceré, en mi casa quieren hacer un pollo asado
// por mi graduación :c a parte es navidad, oh blanca navidad ;-;
public class Jugador : MonoBehaviour
{
    public GameManager gameManager;
    public float fuerzaSalto;
    public int vidas;

    private Rigidbody2D rb;
    private Animator anim;

    public TextMeshProUGUI textoVida;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    //Lumi Vargas Moreno. POO. Primera mecánica agregada: El usuario podrá presionar dos o tres veces la barra de espacio para aumentar la fuerza de salto ,
        //la mecánica central de esto es que el jugador tenga ventaja sobre los objetos, además de hacer más atractiva la experiencia.  
    void Update()
    {
        if (gameManager.start)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                anim.SetBool("estaSaltando", true);
                rb.AddForce(new Vector2(0, fuerzaSalto));

                textoVida.text = "Vidas: " + vidas;
            }
        }


        if (gameManager.gameOver)
        {
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Suelo")
        {
            anim.SetBool("estaSaltando", false);
        }
//Como extra de estética al juego, anexé el mapa de fin del juego, así como que el mismo se pueda reinciar utilizando la tecla "x"
        if (collision.gameObject.tag == "Obstaculo")
        {
            gameManager.gameOver = true;
        }
    }
}
