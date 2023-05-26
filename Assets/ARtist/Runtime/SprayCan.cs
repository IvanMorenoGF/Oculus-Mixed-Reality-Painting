using UnityEngine;

public class SprayCan : MonoBehaviour
{
    [SerializeField] Transform line = null;

    Transform graffity;

    bool PressNozzle => OVRInput.GetDown(OVRInput.Button.SecondaryIndexTrigger);
    bool ReleaseNozzle => OVRInput.GetUp(OVRInput.Button.SecondaryIndexTrigger);

    void Update()
    {
        if (PressNozzle) StartGraffiti();
        else if (ReleaseNozzle) FinishGraffity();
    }

    void StartGraffiti() => graffity = Instantiate(line, transform);
    void FinishGraffity() => graffity.parent = null;
}