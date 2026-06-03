using UnityEngine;
using UnityEngine.InputSystem;

public class InteraccionLuz : MonoBehaviour
{
    [Header("Arrastra aquí tu Point Light")]
    public Light focoInteractivo;
    
    [Header("Arrastra aquí tu Botiquín")]
    public GameObject botiquin;

    public float distanciaInteraccion = 3f;

    void Start()
    {
        // Apaga la luz al iniciar
        if (focoInteractivo != null)
        {
            focoInteractivo.enabled = false;
        }

        // Oculta el botiquín al iniciar
        if (botiquin != null)
        {
            botiquin.SetActive(false); 
        }
    }

    void Update()
    {
        if (Keyboard.current == null) return;

        if (Keyboard.current.eKey.wasPressedThisFrame)
        {
            RaycastHit hit;
            if (Physics.Raycast(Camera.main.transform.position, Camera.main.transform.forward, out hit, distanciaInteraccion))
            {
                if (hit.transform.CompareTag("Interruptor"))
                {
                    // Prende/apaga la luz
                    if (focoInteractivo != null)
                    {
                        focoInteractivo.enabled = !focoInteractivo.enabled;
                    }
                    
                    // Muestra/oculta el botiquín
                    if (botiquin != null)
                    {
                        botiquin.SetActive(!botiquin.activeSelf);
                    }
                }
            }
        }
    }
}