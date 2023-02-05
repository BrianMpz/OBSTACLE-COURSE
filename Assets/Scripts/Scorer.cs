using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorer : MonoBehaviour
{
    int hits = 0;
   private void OnCollisionEnter(Collision other) 
    {
        if(other.gameObject.tag == "Untagged")
        {
            hits++;
            if(hits == 1)
            {
                Debug.Log("you've bumped "+hits +" time:!");
            }
            else
            {
                Debug.Log("you've bumped "+hits +" times:!");
            }
        }
    }

}
