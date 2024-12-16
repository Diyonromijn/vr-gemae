using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Stream : MonoBehaviour
{
    private LineRenderer lineRenderer = null;
    private Vector3 targetPosition = Vector3.zero;
    private void Awake()
    {
        lineRenderer = GetComponent<LineRenderer>();

    }
    private void Start()
    {
        MoveToPosition(0, transform.position);
        MoveToPosition(1, transform.position);
    }
    public void Begin()
    {
        StartCoroutine(BeginPour());
    }
    private IEnumerator BeginPour()
    {
        while (gameObject.activeSelf)
        {
            targetPosition = FindEndpoint();
            MoveToPosition(0, transform.position);
            MoveToPosition(1, transform.position);
            yield return null; 
        }
       
    }
    private Vector3 FindEndpoint()
    {
        RaycastHit hit;
        Ray ray = new Ray(transform.position, Vector3.down);
        Physics.Raycast(ray, out hit,2.0f);
        Vector3 endpoint = hit.collider ? hit.point : ray.GetPoint(2.0f);
        return endpoint;

    }
    private void MoveToPosition(int index, Vector3 targetPosition)
    { 
        lineRenderer.SetPosition(index, targetPosition);
    }
}