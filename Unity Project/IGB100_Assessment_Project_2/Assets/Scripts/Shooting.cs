using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public string noiseMakerTag; // tag used on the noisemakers
    public float shootingRange; // how far the player can shoot
    private Camera cam; // the camera on the player
    // Start is called before the first frame update
    void Start()
    {
        //get the only camera in the scene
        cam = FindObjectOfType<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        //when the player releses the fire1 button
        if(Input.GetButtonUp("Fire1"))
        {
            Debug.Log("shoot");
            RaycastHit hit;
            Vector3 fwd = cam.transform.forward;
            if(Physics.Raycast(cam.transform.position, fwd, out hit, shootingRange))
            {
                Debug.Log(hit.collider.name);
                if (hit.collider.gameObject.tag == noiseMakerTag)
                {
                    Destroy(hit.collider.gameObject);
                }
                
            }
        }
    }
}
