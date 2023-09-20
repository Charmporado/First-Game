using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class CAMERACONTROLL : MonoBehaviour
{

    public GameObject player;

    private Vector3 offset;


    // Use this for initialization
    void Start()
    {
        offset = transform.position - player.transform.position;

    }


    // Update is called once per frame
    void Update()
    {
        transform.position = player.transform.position + offset;
        
    }
}