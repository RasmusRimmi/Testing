using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//public class Tutorials : MonoBehaviour
//{
//    public GameObject tutorial1;
//    [SerializeField] private Player1Controller player1;
//    [SerializeField] private Player2Controller player2;
//    [SerializeField] private Checkpoint checkpoint;


//    public Timer time;

//    // Start is called before the first frame update
//    void Start()
//    {
//        tutorial1.SetActive(true);
//    }

//    // Update is called once per frame
//    void Update()
//    {
//        Checkpoints();
//    }

//    public void Checkpoints()
//    {
//        //if (tutorial1.activeSelf)
//        //{
//        //    //DisablePlayerControllers();
//        //    //time.startTimer = false;

//        //    //if (Input.GetKeyDown(KeyCode.Return))
//        //    //{
//        //    //    tutorial1.SetActive(false);
//        //    //    time.startTimer = true;
//        //    //}
//        //}
//        //else
//        //{
//        //    //EnablePlayerControllers();
//        //}

//        for (int i = 0; i < checkpoint.tutorials.Length; i++)
//        {
//            if (Input.GetKeyDown(KeyCode.Return))
//            {
//                checkpoint.tutorials[i].SetActive(false);
//                time.startTimer = true;
//            }

//            //if (checkpoint.tutorials[i].activeSelf)
//            //{
//            //    //DisablePlayerControllers();
//            //    //time.startTimer = false;

//            //    //if (Input.GetKeyDown(KeyCode.Return))
//            //    //{
//            //    //    checkpoint.tutorials[i].SetActive(false);
//            //    //    time.startTimer = true;
//            //    //}

//            //    break;
//            //}
//        }
//    }


//    //private void DisablePlayerControllers()
//    //{
//    //    player1.GetComponent<Player1Controller>().enabled = false;
//    //    player1.rb.velocity = Vector3.zero;
//    //    player1.animator.SetFloat("Speed", 0f);
//    //    player2.GetComponent<Player2Controller>().enabled = false;
//    //    player2.rb.velocity = Vector3.zero;
//    //    player2.animator.SetFloat("Speed", 0f);
//    //}

//    //private void EnablePlayerControllers()
//    //{
//    //    player1.GetComponent<Player1Controller>().enabled = true;
//    //    player2.GetComponent<Player2Controller>().enabled = true;
//    //}

//}
