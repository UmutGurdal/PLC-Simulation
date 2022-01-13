using UnityEngine;
using Sirenix.OdinInspector;
using S7.Net;
using System.Collections.Generic;
using TMPro;

public class CommunicationManager : MonoBehaviour
{
    public Plc plc;
    private GameData data;

    public bool isConnected;
    private bool invoking;

    [SerializeField] private TextMeshProUGUI connectionText;

    private void Start()
    {
        data = GameManager.ins.gameData;
        connectionText.text = "Ba�lant� Durumu: Ba�l� De�il";
    }

    [Button]
    public void ConnectPlc()
    {
        connectionText.text = "Ba�lant� Durumu: Ba�lan�yor";
        if (!invoking) InvokeRepeating(nameof(CheckConnection), 0, 0.5f);
        plc = new Plc(data.cpuType, data.ip, (short)data.rack, (short)data.slot);

        if (plc != null)
        {
            plc.Open();
            isConnected = true;
            connectionText.text = "Ba�lant� Durumu: Ba�land�";
        }

        else connectionText.text = "Ba�lant� Durumu: PLC Bulunamad�";
    }

    [Button]
    public bool ReadBool(string blockAddress)
    {
        return (bool)plc.Read(blockAddress);
    }

    public void WriteBool(string blockAddress, bool value) 
    {
        plc.Write(blockAddress, value);
    }

    public int ReadInt(string blockAddress) 
    {
        return (ushort)plc.Read(blockAddress);
    }

    public void WriteInt(string blockAddress, int value)
    {
        plc.Write(blockAddress, value);
    }

    [Button]
    public void DisconnectPLC()
    {
        plc.Close();
        plc = null;
        Debug.Log("Ba�lant� Durumu: Ba�lant� Kesildi");
    }

    private void CheckConnection() 
    {
        invoking = true;
        if (isConnected)
        {
            if(plc == null) connectionText.text = "Ba�lant� Durumu: Ba�lant� Koptu";
        }

        else connectionText.text = "Ba�lant� Durumu: Ba�lant� Denemesi Ba�ar�s�z";
    }
}
