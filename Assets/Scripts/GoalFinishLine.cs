using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalFinishLine : MonoBehaviour
{
    public bool isTouched;
    void Start()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        isTouched = true;
        if (other.gameObject.tag == "Player" && isTouched == true)
        {
            Debug.Log("Success");
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
