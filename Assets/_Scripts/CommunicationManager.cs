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
        connectionText.text = "Baðlantý Durumu: Baðlý Deðil";
    }

    [Button]
    public void ConnectPlc()
    {
        connectionText.text = "Baðlantý Durumu: Baðlanýyor";
        if (!invoking) InvokeRepeating(nameof(CheckConnection), 0, 0.5f);
        plc = new Plc(data.cpuType, data.ip, (short)data.rack, (short)data.slot);

        if (plc != null)
        {
            plc.Open();
            isConnected = true;
            connectionText.text = "Baðlantý Durumu: Baðlandý";
        }

        else connectionText.text = "Baðlantý Durumu: PLC Bulunamadý";
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
        Debug.Log("Baðlantý Durumu: Baðlantý Kesildi");
    }

    private void CheckConnection() 
    {
        invoking = true;
        if (isConnected)
        {
            if(plc == null) connectionText.text = "Baðlantý Durumu: Baðlantý Koptu";
        }

        else connectionText.text = "Baðlantý Durumu: Baðlantý Denemesi Baþarýsýz";
    }
}
