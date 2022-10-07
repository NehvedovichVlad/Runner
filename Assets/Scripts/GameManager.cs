using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public GameObject Obstacle;
    public Transform SpawnPoint;
    private int _score = 0;

    public TextMeshProUGUI ScoreText;
    public GameObject PlayButton;
    public GameObject Player;

    void Start(){
        
    }

    IEnumerator SpawnObstacles()
    {
        while(true){
            float waitTime = Random.Range(1f, 2f);
            yield return new WaitForSeconds(waitTime);
            Instantiate(Obstacle, SpawnPoint.position, Quaternion.identity);
        }
    }

    private void ScoreUp(){
        _score ++;
        ScoreText.text = _score.ToString();
    }

    public void GameStart(){
        Player.SetActive(true);
        PlayButton.SetActive(false);
        StartCoroutine("SpawnObstacles");
        InvokeRepeating("ScoreUp", 2f, 1f);
    }
}
