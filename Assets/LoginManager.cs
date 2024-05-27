using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoginManager : MonoBehaviour
{
    public InputField InputTexto;
    public string contraseña;
    //CUANDO EL USUARIO APRIETE EL BOTON BTN_ACEPTAR; DEBE DESCRIBIRSE UN MENSAJE EN LA CONSOLA
    //SI EL TEXTO DEL INPUT PASSWORD COINCIDE CON UNA CONTRASEÑA PREDEFIDINA, POR NOSTROS
    //ESCRIBIR "Access Granted", sino ESCRIBIR "Access denied"

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Btn_Aceptar()
    {
        if (InputTexto.text == contraseña)
        {
            Debug.Log("Access Granted");
        }
        else
        {
            Debug.Log("Access Denied");
        }
    }
}
