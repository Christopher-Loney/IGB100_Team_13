using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public string noiseMakerTag;
    public float shootingRange;
    private Camera cam;
    // Start is called before the first frame update
    void Start()
    {
        cam = FindObjectOfType<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonUp("Fire1"))
        {
            Debug.Log("shoot");
            RaycastHit hit;

            if(Physics.Raycast(cam.transform.position, Vector3.forward, out hit, shootingRange))
            {
                Debug.Log(hit.collider.gameObject.name);
                if (hit.collider.gameObject.tag == noiseMakerTag)
                {
                    Destroy(hit.collider.gameObject);
                }
                
            }
        }
    }
}
