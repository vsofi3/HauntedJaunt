using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class LerpFunction : MonoBehaviour
{
    [SerializeField]
    private Transform player;

    [SerializeField]
    private Transform enemy;

    [SerializeField]
    [Range(0f, 1f)]
    private float lerpPct = 0.5f;

    public float finalValue;

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.Lerp(player.position, enemy.position, lerpPct);
        transform.rotation = Quaternion.Lerp(player.rotation, enemy.rotation, lerpPct);
    }
}
