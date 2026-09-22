using UnityEngine;

public class Shape : MonoBehaviour
{
    // ENCAPSULATION (Encapsulación)
    private string shapeName = "Figura General";
    public string ShapeName
    {
        get { return shapeName; }
        set
        {
            if (!string.IsNullOrEmpty(value))
                shapeName = value;
        }
    }

    // POLYMORPHISM (Polimorfismo - Método Virtual)
    public virtual void DisplayText()
    {
        Debug.Log("Has seleccionado: " + ShapeName);
    }

    // ABSTRACTION (Abstracción)
    public void DisplayInfo()
    {
        DisplayText();
    }

    private void OnMouseDown()
    {
        DisplayInfo();
    }
}