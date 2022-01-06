using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using S7.Net;

[CreateAssetMenu(menuName = "GameData", fileName = "Data")]
public class GameData : ScriptableObject
{
    public CpuType cpuType = CpuType.S71200;
    public string ip = "127.000.0.1";
    public int rack = 2;
    public int slot = 0;
}
