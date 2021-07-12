using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BManager : MonoBehaviour
{
    public Battle ActiveBattle;
    void Start()
    {

    }

    void Update()
    {
        
    }
    public IEnumerator doBPM()
    {
        yield return new WaitForSeconds(1);
    }
}

[System.Serializable]
public class Battle
{
    public AudioClip song;
    public int id,bpm;
    public float delay;
    public GameObject enemy;
    public List<GameObject> attacks;
}
