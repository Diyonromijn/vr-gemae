using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class resetbutton : MonoBehaviour
{
    public List<GameObject> foodReset = new();
    public List<Vector3> PositionReset = new();
    public List<Quaternion> rotationReset = new();

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < foodReset.Count; i++)
        {
            PositionReset.Add(foodReset[i].transform.position);
            rotationReset.Add(foodReset[i].transform.rotation);
        }
    }

    public void ResetObjects()
    { 
        for(int i = 0;i < foodReset.Count; i++)
        {
            foodReset[i].transform.position = PositionReset[i];
            foodReset[i].transform.rotation = rotationReset[i];
        }
    }
}
