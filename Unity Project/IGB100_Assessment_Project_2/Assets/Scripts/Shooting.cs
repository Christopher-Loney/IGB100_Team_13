using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Shooting : MonoBehaviour
{
    public string noiseMakerTag; // tag used on the noisemakers
    public float shootingRange; // how far the player can shoot
    public int ammo = 6; // the players ammo count
    public List<Image> casings;
    public float reloadTime;
    public ParticleSystem bubbles;
    public AudioSource gunShot;
    private Camera cam; // the camera on the player
    private GameManger gameManger;// the game manager
    // Start is called before the first frame update
    void Start()
    {
        //get the only camera in the scene
        cam = FindObjectOfType<Camera>();
        // get the game manager
        gameManger = FindObjectOfType<GameManger>();
    }

    // Update is called once per frame
    void Update()
    {

        //when the player releses the fire1 button
        if(Input.GetButtonUp("Fire1") && ammo > 0)
        {
            Debug.Log("shoot");
            ammo--;
            if (bubbles.isPlaying)
            {
                bubbles.Stop();
                bubbles.Play();
            }
            else
            {
                bubbles.Play();
            }
            if(gunShot.isPlaying)
            {
                gunShot.Stop();
                gunShot.Play();
            }
            else
            {
                gunShot.Play();
            }
            casings[ammo].gameObject.SetActive(false);
            RaycastHit hit;
            Vector3 fwd = cam.transform.forward;
            if(Physics.Raycast(cam.transform.position, fwd, out hit, shootingRange))
            {
                Debug.Log(hit.collider.name);
                if (hit.collider.gameObject.tag == noiseMakerTag)
                {
                    GameObject parent = hit.collider.transform.parent.gameObject;
                    gameManger.noiseMakers.Remove(parent);
                    Destroy(parent);
                }
                
            }
            if(ammo <= 0)
            {
                StartCoroutine(Reload());
            }
        }
    }
    public IEnumerator Reload()
    {
        yield return new WaitForSeconds(reloadTime);
        ammo = 6;
        for (int i = 0; i < casings.Count; i++)
        {
            casings[i].gameObject.SetActive(true);
        }
        StopCoroutine(Reload());
    }
}
