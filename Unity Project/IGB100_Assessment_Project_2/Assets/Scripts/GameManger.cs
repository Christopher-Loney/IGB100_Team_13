using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManger : MonoBehaviour
{
    public List<GameObject> noiseMakers;
    public GameObject player;
    private CursorSettings CursorSettings;
    // Start is called before the first frame update
    void Start()
    {
        CursorSettings = this.GetComponent<CursorSettings>();
    }

    // Update is called once per frame
    void Update()
    {
        if(noiseMakers.Count < 1)
        {
            SceneManager.LoadScene(0);
        }
        if(Input.GetButtonDown("Cancel"))
        {
            CursorSettings.inMenu = !CursorSettings.inMenu;
        }
    }
}
