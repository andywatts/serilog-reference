// using Serilog;
// using Serilog.Sinks.Seq;
// using Serilog.Sinks.Unity3D;
using UnityEngine;

public class Logger : MonoBehaviour
{
    
    void OnEnable()
    {
        Application.logMessageReceived += Log.HandleUnityLog;
    }

    void OnDisable()
    {
        Application.logMessageReceived -= Log.HandleUnityLog;
    }
    
    

    void Start()
    {
        Debug.Log("Default logger");
        var position = new { Latitude = 25, Longitude = 134 };
        var elapsedMs = 34;
        Log.Logger.Information("Processed {@Position} in {Elapsed} ms.", position, elapsedMs);
    }
}