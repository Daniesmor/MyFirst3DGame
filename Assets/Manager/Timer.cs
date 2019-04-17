using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{


    public float maxTime = 60f;

    private float countdown = 0f;

    // Start is called before the first frame update
    void Start()
    {
        countdown = maxTime;
    }

    // Update is called once per frame
    void Update()
    {
        /*El deltaTime es el tiempo en segundos que ha pasado desde que se 
        renderizó en pantalla el frame anterior
            */
        countdown -= Time.deltaTime;

        Debug.Log("Cuenta atrás :" + countdown);
        if(countdown <= 0)
        {
            Debug.Log("Te has quedado sin tiempo... HAS PERDIDO!!!");

            Coin.coinsCount = 0;

            SceneManager.LoadScene("MainScene");
        }
    }
}
