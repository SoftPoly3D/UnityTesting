//Librerias
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//           Nombre de clase  Herencia
public class test : MonoBehaviour
    //La llave es donde inica el scope 
{
    //Variables 
    private int numero = 89;
    public string texto = "";


    // se llama el primer frame del juego 
    void Start()
    {
        print(texto);
    }

    // se llama cada frame del juego //los frames dependen de que tan poderoso es el equipo (pc)
    void Update()
    {
        print(numero);
    }
}
//  Aqui termina el scope 
