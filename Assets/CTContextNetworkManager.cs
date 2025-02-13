using CTHeadless;
using System.Threading.Tasks;
using UnityEngine;

public class CTContextNetworkManager : MonoBehaviour
{
    [Header("ChainTactics")]
    [SerializeField] public string url;
    [SerializeField] public string privateKey;
    [SerializeField] public string worldAddress;

    [Header("Sequencer")]
    [SerializeField] public string ctSequencerURl;

    void Awake()
    {
        CTCommon.Logger.LogFn = (string msg, CTCommon.Logger.LogLevel level) =>
        {
            Debug.Log(msg);
        };
    }

    // Start is called before the first frame update
    void Start()
    {
        FindMatch().Wait(5000);
    }
    async Task FindMatch()
    {
        CTServerContext ctContext = new CTServerContext(url, privateKey, worldAddress, ctSequencerURl);

        await ctContext.FindMatch();
        Debug.Log("Found mach!");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
