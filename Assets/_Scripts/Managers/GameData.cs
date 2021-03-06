using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using S7.Net;

[CreateAssetMenu(menuName = "GameData", fileName = "Data")]
public class GameData : ScriptableObject
{
    public CpuType cpuType = CpuType.S7200;
    public string ip = "192.168.0.1";
    public int rack = 0;
    public int slot = 1;
    [Space]
    public string BoolBlockToRead = "DB1.DBX0.0";
    public string BoolBlockToWrite = "DB1.DBX0.1";
    public string IntBlockToRead = "DB1.DBX0.2";
    public string IntBlockToWrite = "DB1.DBX0.3";
}
