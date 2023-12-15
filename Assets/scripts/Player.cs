using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]//permite que possa ser editados os valore no inspetor
public struct MoveControler//teclas que fazem o movimento
{
    public KeyCode Rigth;
    public KeyCode Left;
    public KeyCode Up;
    public KeyCode Down;
}

public class Player : MonoBehaviour
{
    private Animator ani;
    private SpriteRenderer sprite;
    public MoveControler moveCtr;//pede para defini na unity 
    public bool cuzin = true; //projeto atulizado
    public bool pinto = true;//nova linha adicionada
    void Start()
    {
        ani = GetComponent<Animator>();//parametros do animator "vivo"(bool) e "run"(bool)
        sprite = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        // Lógica de movimento aqui usando moveCtr
        if(Input.GetKey(moveCtr.Rigth)||Input.GetKey(moveCtr.Left)) {
        ani.SetBool("run",true);
        }
       else {
        ani.SetBool("run",false);
        sprite.flipX = Input.GetKey(moveCtr.Left); //faz olhar para tras quando ele estiver se movendo para traz
       }
        if (cuzin){
            Debug.Log ("meu pau"); 
        }
        if (pinto){
            Debug.Log ("meu cuzinho"); 
        }
        
    }
}
