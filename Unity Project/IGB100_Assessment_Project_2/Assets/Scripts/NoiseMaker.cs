using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoiseMaker : MonoBehaviour
{
    public float rotationSpeed;
    public float hoverHight;

    private GameObject noiseMakerModel;
    // Start is called before the first frame update
    void Start()
    {
        noiseMakerModel = this.gameObject;
        noiseMakerModel.transform.position += new Vector3 (0, hoverHight, 0);
    }

    // Update is called once per frame
    void Update()
    {
        noiseMakerModel.transform.Rotate(0, rotationSpeed, 0, Space.Self);
    }
}
