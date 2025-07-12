using UnityEngine;

public class ResetOnDelete : MonoBehaviour
{
    private void OnDestroy()
    {
        var spawner = FindObjectOfType<UnityEngine.XR.Interaction.Toolkit.Samples.StarterAssets.ObjectSpawner>();
        if (spawner != null)
        {
            spawner.ResetSpawner();
        }
    }
}
