using UnityEngine;
using UnityEngine.UI;


public class FPScounter : MonoBehaviour
{
    public float updateInterval = 0.5f;
    private float accum = 0.0f;
    private int frames = 0;
    private float timeleft;
    private float fps;

    void Start()
    {
        if (!GetComponent<Text>())
        {
            Debug.Log("UtilityFramesPerSecond needs a GUIText component!");
            enabled = false;
            return;
        }
        timeleft = updateInterval;
    }

    void Update()
    {
        timeleft -= Time.deltaTime;
        accum += Time.timeScale / Time.deltaTime;
        ++frames;

        if (timeleft <= 0.0)
        {
            fps = accum / frames;
            GetComponent<Text>().text = fps.ToString("f2");
            timeleft = updateInterval;
            accum = 0.0f;
            frames = 0;
        }
    }
}
