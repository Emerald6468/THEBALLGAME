using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Rendering;

public class BallCollision : MonoBehaviour
{
    public UnityEvent unityEvent;
    public GameObject theTrigger;
    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Ball"))
        {
            Debug.Log("teesst");
            Destroy(other.gameObject);
            GameManager.BallOut = false;
        }
    }
}