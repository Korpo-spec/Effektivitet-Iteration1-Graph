using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class BallManager : MonoBehaviour
{
    [SerializeField] private GameObject ball;
    [SerializeField]private Vector2Int amountToCreate;
    

    [SerializeField] private float spacing;
    // Start is called before the first frame update
    void Start()
    {
        float startposX = (spacing * amountToCreate.x) /2 - spacing/2;
        float startposY = (spacing * amountToCreate.y) / 2 - spacing/2;
        for (int i = 0; i < amountToCreate.y; i++)
        {
            for (int j = 0; j < amountToCreate.x; j++)
            {
                Instantiate(ball, new Vector3(-startposX +j * spacing, -startposY + i * spacing, 0), quaternion.identity);
            }
        }
    }

    private void OnDrawGizmos()
    {
        float startposX = (spacing * amountToCreate.x) /2 - spacing/2;
        float startposY = (spacing * amountToCreate.y) /2 - spacing/2;
        for (int i = 0; i < amountToCreate.y; i++)
        {
            for (int j = 0; j < amountToCreate.x; j++)
            {
                Gizmos.DrawSphere(new Vector3(-startposX +j * spacing, -startposY +i * spacing, 0), ball.transform.localScale.x/2);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
