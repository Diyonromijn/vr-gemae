﻿using System.Collections;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.UIElements;

public class PourDetector : MonoBehaviour
{
    public int pourThreshold = 45;
    public Transform origin = null;
    public GameObject streamPrefab = null;

    private bool isPouring = false;
    private Stream currentStream = null;

    private void Update()
    {
        bool pourCheck = CalculatePourAngle() < pourThreshold;
        if (isPouring != pourCheck)
        { 
            isPouring = pourCheck;

            if (isPouring)
            {
                StartPour();

            }
            else
            {
                EndPour();
            }
        }
        
    }
    private void StartPour()
    {
        Debug.Log("start");
        currentStream = CreateStream();
        currentStream.Begin();
    }
    private void EndPour()
    {
        Debug.Log("Stop");
    }
    private float CalculatePourAngle()
    {
        return transform.forward.y * Mathf.Rad2Deg;
    }
    private Stream CreateStream() 
    { 
        GameObject streamObject = Instantiate(streamPrefab, origin.position,Quaternion.identity,transform);
        return streamObject.GetComponent<Stream>();    
    }
}