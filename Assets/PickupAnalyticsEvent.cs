using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Services.Core;
using Unity.Services.Analytics;

public class PickupAnalyticsEvent : MonoBehaviour
{
    public string objectName;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SendEvent()
    {
        // https://docs.unity.com/analytics/en/manual/RecordingCustomEvents 
        // Send custom event
        Dictionary<string, object> parameters = new Dictionary<string, object>()
        {
            { "object", objectName },
        };
        // The ‘myEvent’ event will get queued up and sent every minute
        AnalyticsService.Instance.CustomData("objectPickup", parameters);

        // Optional - You can call Events.Flush() to send the event immediately
        AnalyticsService.Instance.Flush();
    }
}
