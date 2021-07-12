using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Battles : MonoBehaviour
{

    public Battle TestBattle = new Battle();
    void Start()
    {
        // Test Battle
        TestBattle.id = 0;
        TestBattle.delay = 2.0f;
        TestBattle.bpm = 151;
    }
}
