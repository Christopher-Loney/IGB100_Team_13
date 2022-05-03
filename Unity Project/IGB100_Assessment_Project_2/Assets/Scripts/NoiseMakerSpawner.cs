using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoiseMakerSpawner : MonoBehaviour
{
    public int noiseMakersToSpawn;
    public List<GameObject> spawnPoints;
    public List<GameObject> noiseMakers;
    private GameManger gameManger;
    // Start is called before the first frame update
    void Start()
    {
        gameManger = this.GetComponent<GameManger>();
        if(noiseMakersToSpawn > spawnPoints.Count)
        {
            noiseMakersToSpawn = spawnPoints.Count;
        }
        for (int i = 0; i < noiseMakersToSpawn; i++)
        {
            GameObject point = spawnPoints[Random.Range(0, spawnPoints.Count)];
            spawnPoints.Remove(point);
            GameObject noiseMaker = noiseMakers[Random.Range(0, noiseMakers.Count)];

            GameObject noiseMakerInst = Instantiate(noiseMaker, point.transform.position, Quaternion.identity);
            gameManger.noiseMakers.Add(noiseMakerInst);
        }   
    }
}
