using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterFollow : MonoBehaviour
{
    public GameObject player;
    private Vector3 distancia;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        distancia = transform.position - player.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = player.transform.position + distancia;
    }
}
