using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{

  // Start is called before the first frame update
  void Start()
{

}

// update is called once per frame
void Update()
{

}

void OnCollisionEnter(Collision c)
{
    if (Equals(c.GetComponent<collider>().tag, "wall"))
   {
      // We hit a wall...what should we do?
      // Player takes damage
      // Restart the level.
   }
}

}