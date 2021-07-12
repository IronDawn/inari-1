using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Music : MonoBehaviour
{

    public Battle activeBattle;
    public int section,beat,relativebeat = 0;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("delay");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator delay()
    {
        float waitTime = Time.time + activeBattle.delay;
        yield return new WaitUntil(() => Time.time > waitTime);
        relativebeat = 1;
        StartCoroutine("doBPM");
    }
    IEnumerator doBPM()
    {
        while(true)
        {
            float waitTime = Time.time + (60.0f / activeBattle.bpm);
            yield return new WaitUntil(() => Time.time > waitTime);

            Debug.Log("Beat");
            beat++;
            relativebeat++;
            if (beat % 4 == 0)
            {
                Debug.Log("New Section on BEAT " + beat);
                section++;
                relativebeat = 1;
            }
        }
    }
}
