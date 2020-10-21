using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/////////////////////////////////////////////////////
// Source File Name: BackgroundController.cs       //
// Student Name: Beining Liu                       //
// Student ID: 101193350                           //
// Date Last Modified: Oct 22                      //
// Program Description: background movement script.//
/////////////////////////////////////////////////////

//   Revision History:            
// - Changed all vertical variable to horizontal variable
// - Changed reset method so the reset position matches player screen position
// - Changed move method so that the background move horizontally
// - Changed check bounds method so the background reset properly


public class BackgroundController : MonoBehaviour
{
    public float horizontalSpeed;
    public float horizontalBoundary;

    // Update is called once per frame
    void Update()
    {
        _Move();
        _CheckBounds();
    }

    private void _Reset()
    {
        transform.position = new Vector3(horizontalBoundary, 0.0f);
    }

    private void _Move()
    {
        transform.position -= new Vector3(horizontalSpeed, 0.0f) * Time.deltaTime;
    }

    private void _CheckBounds()
    {
        // if the background is lower than the bottom of the screen then reset
        if (transform.position.x <= -horizontalBoundary)
        {
            _Reset();
        }
    }
}
