using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
   public float SpeedObstacle;


    void Update()
    {
        transform.Translate(Vector3.forward * SpeedObstacle * Time.deltaTime);
    }

    private void OnBecameInvisible(){
        Destroy(gameObject);
    }
}
