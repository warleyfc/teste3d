using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeguirJogador : MonoBehaviour
{
    public GameObject player;
    private Quaternion dirRotacao;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Follow();
    }

    void Follow(){
        transform.position = Vector3.MoveTowards(transform.position, player.gameObject.transform.position, 5*Time.deltaTime);
		dirRotacao = Quaternion.LookRotation(player.transform.position - transform.position);
		transform.rotation = Quaternion.Slerp(transform.rotation, dirRotacao, 15 * Time.deltaTime);
    }
}
