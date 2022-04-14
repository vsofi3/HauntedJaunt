using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//[ExecuteInEditMode]
public class DotProduct : MonoBehaviour
{
    public Transform player;
    public float dotProd;
    public Vector3 playerPos;
    public Vector3 enemyPos =  new Vector3(15.2f, 0.0f, 0.8f);
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        playerPos = gameObject.transform.position;
        enemyPos = player.position;

        dotProd = Vector3.Dot(playerPos, enemyPos);
    }
}
