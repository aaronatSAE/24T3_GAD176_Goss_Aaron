using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DotProductChecker : MonoBehaviour
{
    [SerializeField] private GameObject player;
    [SerializeField] private GameObject enemy;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Check the directions of both characters to see if they are facing the same way
        // If our dot product is 1,
        // they are facing the same way
        if(Vector3.Dot(player.transform.forward, enemy.transform.forward) > 0.5)
        {
            Debug.Log("Facing the same way!");
        }
        // If it is -1,
        // they are facing opposite directions
        if (Vector3.Dot(player.transform.forward, enemy.transform.forward) < -0.5)
        {
            Debug.Log("Facing opposite directions!");
        }
        // If it is 0, they are facing perpendicularly to each other
        // That is... between -0.5 and 0.5 (we use AND for this)
        if (Vector3.Dot(player.transform.forward, enemy.transform.forward) < 0.5 && Vector3.Dot(player.transform.forward, enemy.transform.forward) > -0.5)
        {
            Debug.Log("Facing perpendicularly!");
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.DrawLine(player.transform.position, player.transform.position + player.transform.forward);
        Gizmos.DrawLine(enemy.transform.position, enemy.transform.position + enemy.transform.forward);
    }
}
