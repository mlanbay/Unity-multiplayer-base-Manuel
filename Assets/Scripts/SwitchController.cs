using Unity.Mathematics;
using UnityEngine;
using ED.SC;

public class SwitchController : MonoBehaviour
{
    Behaviour halo;

    private void Start()
    {
        halo = (Behaviour)GetComponent("Halo");
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        halo.enabled = true;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        SmartConsole.Log("exit Switch");
        halo.enabled = false;
    }

}
