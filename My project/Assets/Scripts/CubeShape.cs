using UnityEngine;

// INHERITANCE (Herencia - Hereda de Shape)
public class CubeShape : Shape
{
    private void Start()
    {
        ShapeName = "Cubo Personalizado";
    }

    // POLYMORPHISM (Polimorfismo - Sobrescribe el método)
    public override void DisplayText()
    {
        Debug.Log("¡Hola! Soy un " + ShapeName + " y respondo al clic.");
    }
}