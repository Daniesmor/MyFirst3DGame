/*
*
*
*/
using System.Collections;
using UnityEngine;

public class Coin : MonoBehaviour
{
    //PROPIEDADES Y MÉTODOS
    //VARIABLE GLOBAL Y ESTÁTICA (una para todas las monedas)
    public static int coinsCount = 0;


    // Start is called before the first frame update
    void Start()
    {
        
        Coin.coinsCount++;
        Debug.Log("El juego ha comenzado y ahora hay " + Coin.coinsCount + " monedas");

    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log("Estamos en el update");
    }

    /*
     * Metodo para llamar automaticamente cuando otro collider entra con el
     * que tiene este script 
    */
    private void OnTriggerEnter(Collider otherCollider)
    {
        if (otherCollider.CompareTag("Player") == true)
        {
            Debug.Log("Has cogido una moneda");
            Coin.coinsCount--;

            Debug.Log("Quedan " + Coin.coinsCount + " monedas");

            if(Coin.coinsCount == 0)
            {
                Debug.Log("El juego ha terminado");

                GameObject gameManager = GameObject.Find("GameManager");

                Destroy(gameManager);

                GameObject[] fireworksSystem = GameObject.FindGameObjectsWithTag("Fireworks");

                foreach(GameObject fireworks in fireworksSystem)
                {
                    fireworks.GetComponent<ParticleSystem>().Play();
                }
            }
            Destroy(gameObject);
        }
    
    }
}
