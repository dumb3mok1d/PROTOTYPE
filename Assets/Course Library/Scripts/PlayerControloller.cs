using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class PlayerControloller : MonoBehaviour
{
    public float horizonalInput;
    public float speed = 10.0f;
    public float xRange = 10.0f;
    public GameObject projectilePrefab;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    
    // Update is called once per frame
    void Update()
    { 
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
            Debug.Log("Fire");
        }

        horizonalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizonalInput * Time.deltaTime * speed);
    }
    

}
