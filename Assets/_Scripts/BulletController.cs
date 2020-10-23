using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/////////////////////////////////////////////////
// Source File Name: BulletController.cs       //
// Student Name: Beining Liu                   //
// Student ID: 101193350                       //
// Date Last Modified: Oct 22                  //
// Program Description: Bullet movement script.//
/////////////////////////////////////////////////

//   Revision History:            
// - Changed all vertical variable to horizontal variable
// - Changed check bounds method to X axis movement
// - Changed move method so the bullet move horizontally

public class BulletController : MonoBehaviour, IApplyDamage
{
    public float horizontalSpeed;

    public float horizontalBoundary;

    public BulletManager bulletManager;
    public int damage;
    
    // Start is called before the first frame update
    void Start()
    {
        bulletManager = FindObjectOfType<BulletManager>();
    }

    // Update is called once per frame
    void Update()
    {
        _Move();
        _CheckBounds();
    }

    private void _Move()
    {
        transform.position += new Vector3(horizontalSpeed, 0.0f, 0.0f) * Time.deltaTime;
    }

    private void _CheckBounds()
    {
        if (transform.position.x > horizontalBoundary)
        {
            bulletManager.ReturnBullet(gameObject);
        }
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        //Debug.Log(other.gameObject.name);
        bulletManager.ReturnBullet(gameObject);
    }

    public int ApplyDamage()
    {
        return damage;
    }
}
