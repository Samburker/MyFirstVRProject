using UnityEngine;

public class BowlingBall : MonoBehaviour
{
    public Material hoverMaterial; // The material to change to when hovering
    private Material defaultMaterial; // The default material of the object

    private Renderer rend;

    private void Start()
    {
        rend = GetComponent<Renderer>();
        defaultMaterial = rend.material;
    }

    public void HoverEnter()
    {
        // Check if hoverMaterial is assigned
        if (hoverMaterial != null)
        {
            rend.material = hoverMaterial;
        }
        else
        {
            Debug.LogWarning("Hover material not assigned for " + gameObject.name);
        }
    }

    public void HoverExit()
    {
        // Revert to default material
        rend.material = defaultMaterial;
    }
}
