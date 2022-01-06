using S7.Net;
using UnityEngine;
using Sirenix.OdinInspector;
using System.Collections.Generic;

public class CommunicationManager : MonoBehaviour
{
    public Plc plc;
    public static CommunicationManager ins;


    // Variables

    public bool bool01;

    // Confugirations

    private GameData data;
    private bool isConnected;

    private void Awake()
    {
        if (ins != null) return;

        ins = this;
    }

    private void Start()
    {
        data = GameManager.ins.gameData;
        ConnectPlc();
    }

    [Button]
    public void ConnectPlc()
    {
        Debug.Log("Plc connecting");
        plc = new Plc(data.cpuType, data.ip, (short)data.rack, (short)data.slot);

        if (plc != null)
        {
            isConnected = true;
            Debug.Log("PLC Defined");
        }

        else Debug.LogError("plc is null");
    }

    [Button]
    public void ReadPlcData(string input)
    {
        if (!isConnected) return;
        plc.Open();
        bool01 = (bool)plc.Read("input");
        //Debug.Log("Read completed");
    }

    public void WriteBool(string output, bool value) 
    {
        if (!isConnected) return;
        plc.Open();
        plc.Write(output, value);
    }

    public void WriteInt(string output, int value)
    {
        if (!isConnected) return;
        plc.Open();
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
