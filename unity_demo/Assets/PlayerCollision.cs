using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter(Collision c)
{
    if (Equals(c.gameObject.tag, "wall"))
    {
        Debug.Log("We hit a wall...what should we do?");

        // Player takes damage.
        // Restart the level.
    }
}
}
