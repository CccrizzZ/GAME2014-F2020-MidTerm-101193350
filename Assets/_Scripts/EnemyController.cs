using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/////////////////////////////////////////////////
// Source File Name: EnemyController.cs       //
// Student Name: Beining Liu                   //
// Student ID: 101193350                       //
// Date Last Modified: Oct 22                  //
// Program Description: enemy movement script.//
/////////////////////////////////////////////////

//   Revision History:            
// - Changed all vertical variable to horizontal variable
// - Changed check bounds method to X axis movement
// - Changed move method so the enemy game object move horizontally





public class EnemyController : MonoBehaviour
{
    public float verticalSpeed;
    public float verticalBoundary;
    public float direction;

    // Update is called once per frame
    void Update()
    {
        _Move();
        _CheckBounds();
    }

    private void _Move()
    {
        transform.position += new Vector3(0.0f,verticalSpeed * direction * Time.deltaTime, 0.0f);
    }

    private void _CheckBounds()
    {
        // check right boundary
        if (transform.position.y >= verticalBoundary)
        {
            direction = -1.0f;
        }

        // check left boundary
        if (transform.position.y <= -verticalBoundary)
        {
            direction = 1.0f;
        }
    }
}
