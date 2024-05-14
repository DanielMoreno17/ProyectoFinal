using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnPollito : MonoBehaviour
{
    [SerializeField] GameObject respawnPollito;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y > -10)
        {
            transform.position = respawnPollito.transform.position;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("incorrecto"))
        {
            transform.position = respawnPollito.transform.position;
            Debug.Log("El pollito tocó una respuesta incorrecta");
        }
    }
}
