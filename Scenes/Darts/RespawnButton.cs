using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnButton : MonoBehaviour
{
    public Dart[] darts;

    public void Press()
    {
        Debug.Log("btn press");
        foreach (var d in darts) d.Respawn();
    }
}
