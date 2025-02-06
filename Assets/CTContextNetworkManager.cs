using CTHeadless;
using UnityEngine;

public class CTContextNetworkManager : MonoBehaviour
{
    [Header("ChainTactics")]
    [SerializeField] public string url;
    [SerializeField] public string privateKey;
    [SerializeField] public string worldAddress;

    [Header("Sequencer")]
    [SerializeField] public string ctSequencerURl;

    // Start is called before the first frame update
    void Start()
    {
        CTServerContext ctContext = new CTServerContext(url, privateKey, worldAddress, ctSequencerURl);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
