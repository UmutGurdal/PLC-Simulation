using S7.Net;
using UnityEngine;
using Sirenix.OdinInspector;
using System.Collections.Generic;

public class CommunicationManager : MonoBehaviour
{
    public Plc plc;

    // Confugirations
    private GameData data;

    // Variables
    public bool isConnected;

    private void Start()
    {
        data = GameManager.ins.gameData;
    }

    [Button]
    public void ConnectPlc()
    {
        Debug.Log("Plc connecting");
        plc = new Plc(data.cpuType, data.ip, (short)data.rack, (short)data.slot);

        if (plc != null)
        {
            plc.Open();
            isConnected = true;
            Debug.Log("PLC Connected");
        }

        else Debug.LogError("plc is null");
    }

    [Button]
    public bool ReadPlcData(string input)
    {
        return (bool)plc.Read(input);
    }

    public void WriteBool(string output, bool value) 
    {
        plc.Write(output, value);
    }

    public void WriteInt(string output, int value)
    {
        plc.Write(output, value);
    }

    [Button]
    public void DisconnectPLC()
    {
        //Debug.Log("Clearing" + plc);
        plc.Close();
        plc = null;
        Debug.Log("Disconnected");
    }
}
