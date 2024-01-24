using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Net.WebSockets;
using System;
using System.Threading;

public class NetworkManager : MonoBehaviour
{
    public static NetworkManager instance;
    ClientWebSocket ws = new ClientWebSocket();
    byte[] buf = new byte[1056];
    // Start is called before the first frame update
    void Start()
    {
        if (instance != null)
        {
            Destroy(this);
        }

        instance = this;
        DontDestroyOnLoad(this);
        
        ConnectToWebSocket();
    }

    async void ConnectToWebSocket()
    {
        Uri serverUri = new Uri("ws://localhost:8080"); // replace with your server URI
        CancellationToken cancellationToken = new CancellationToken();

        try
        {
            await ws.ConnectAsync(serverUri, cancellationToken);
            Debug.Log("Connected to WebSocket server at " + serverUri.ToString());
            Receive();
        }
        catch (Exception ex)
        {
            Debug.LogError("Failed to connect to WebSocket server: " + ex.Message);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (ws.State != WebSocketState.Open)
        {
            return;
        }

        

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Send("Hello from Unity!");
        }

    }

    public async void Send(string message)
    {
        ArraySegment<byte> bytesToSend = new ArraySegment<byte>(System.Text.Encoding.UTF8.GetBytes(message));
        await ws.SendAsync(bytesToSend, WebSocketMessageType.Text, true, CancellationToken.None);
    }

    public async void Receive()
    {
        ArraySegment<byte> bytesReceived = new ArraySegment<byte>(buf);
        WebSocketReceiveResult result = await ws.ReceiveAsync(bytesReceived, CancellationToken.None);
        string message = System.Text.Encoding.UTF8.GetString(buf, 0, result.Count);
        Debug.Log("Received message from server: " + message);
        Receive();
    }
}
