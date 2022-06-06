using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManger : MonoBehaviour
{
    public List<GameObject> noiseMakers;
    public GameObject player;
    public string nextScene;
    [Tooltip("time to complete the level in seconds")]
    public float timer;
    public Text timerText;
    private CursorSettings CursorSettings;
    // Start is called before the first frame update
    void Start()
    {
        CursorSettings = this.GetComponent<CursorSettings>();
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        if(timer <= 0)
        {
            Debug.Log("GameOver");
        }
        int minutes = (int)timer / 60;
        int seconds = (int)timer % 60;
        timerText.text = minutes + ":" + seconds;
        if(noiseMakers.Count < 1)
        {
            SceneManager.LoadScene(nextScene);
        }
        if(Input.GetButtonDown("Cancel"))
        {
            CursorSettings.inMenu = !CursorSettings.inMenu;
        }
    }
}
