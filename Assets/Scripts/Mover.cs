using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
     [SerializeField] float moveSpeed = 10f;

    // Start is called before the first frame update
    void Start()
    {
        PrintTutorialToConsoles();
       
    }

    // Update is called once per frame
    void Update()
    {
       MovePlayer();
    }
    void PrintTutorialToConsoles()
    {
        Debug.Log ("Welcome!");
        Debug.Log ("use WASD or arrows to move");
        Debug.Log("avoid the obsticals");    
    }
   
   void MovePlayer()
   {
        float xValue = Input.GetAxis("Horizontal")*Time.deltaTime * moveSpeed;
        float zValue = Input.GetAxis("Vertical")*Time.deltaTime * moveSpeed;
        transform.Translate(xValue,0,zValue);
   }
}
