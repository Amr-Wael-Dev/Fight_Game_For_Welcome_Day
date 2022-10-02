using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ENEMYSPONER : MonoBehaviour
{
  public GameObject[] enemyprefabs;
  public Transform[] spwnpoint;
 private PlayerMovement playerlife;
 /// <summary>
 /// Awake is called when the script instance is being loaded.
 /// </summary>
 private void Awake()
 {
    playerlife=FindObjectOfType<PlayerMovement>();
 }
  private void Start()
  {
    StartCoroutine(corote());
  }
  private IEnumerator corote()
  {
while(playerlife!= null)
{
    GameObject enemy=Instantiate(enemyprefabs[Random.Range(0,enemyprefabs.Length)],spwnpoint[Random.Range(0,spwnpoint.Length)].position,Quaternion.identity); 
yield return (new WaitForSeconds(5));
}
  }
}
