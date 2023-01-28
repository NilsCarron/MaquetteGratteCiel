using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DeveloppemntManager : MonoBehaviour
{
    public GameObject spotlights;
    public List<GameObject> HUDs;
    public List<Material> materialsPlan;
    private int index = 0;
    public GameObject plan;
    private bool _isDissapearing;
    public GameObject playerPrefab;
    public int indexPressingO;
    public GameObject player;
    public GameObject text ;
    public List<GameObject> PlayersList;

    private GameObject newTrail;
    // Start is called before the first frame update
    void Start()
    {
        PlayersList.Add(player);

        _isDissapearing = false;

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            plan.GetComponent<MeshRenderer>().material = materialsPlan[index];
            if (index > 0)
            {
                HUDs[index-1].SetActive((false));
            }
            HUDs[index].SetActive((true));

            ++index;
            
            if (index >= 3)
            {
                spotlights.SetActive(true);
            }

        }

        if (Input.GetKeyDown(KeyCode.O))
        {
            indexPressingO += 1;
            switch (indexPressingO)
            {

                    case 1:
                        text.GetComponent<TMPro.TextMeshProUGUI>().text = "Lumière du jour";

                    break;
                    
                    case 2:
                        text.GetComponent<TMPro.TextMeshProUGUI>().text = "Lumière du jour<br>Température";
                    break;
                    
                    case 3:
                        text.GetComponent<TMPro.TextMeshProUGUI>().text ="Lumière du jour<br>Température<br>Santé";
                    break;
                    
                    case 4:
                        text.GetComponent<TMPro.TextMeshProUGUI>().text ="Lumière du jour<br>Température<br>Santé<br>Zones ensoleillées";
                    break;
                    
                    case 5:
                            text.GetComponent<TMPro.TextMeshProUGUI>().text =                            "De jour comme de nuit";
                    break;
                    
                    case 6:
                        text.GetComponent<TMPro.TextMeshProUGUI>().text =                            "De jour comme de nuit <br>Hiver comme été";

                    break;
                    
                    case 7:
                        text.GetComponent<TMPro.TextMeshProUGUI>().text =                            "De jour comme de nuit <br>Hiver comme été<br>Chaud";

                    break;
                    
                    case 8:
                        text.GetComponent<TMPro.TextMeshProUGUI>().text =                            "De jour comme de nuit <br>Hiver comme été<br>Chaud<br>Ombre";

                    break;
                    
                    case 9:
                        text.GetComponent<TMPro.TextMeshProUGUI>().text =                            "De jour comme de nuit <br>Hiver comme été<br>Chaud<br>Ombre<br>Végétaux";

                    break;
                    
                    case 10:
                        text.GetComponent<TMPro.TextMeshProUGUI>().text =                            "De jour comme de nuit <br>Hiver comme été<br>Chaud<br>Ombre<br>Végétaux<br>Soleil";

                    break;
                    
                    case 11:
                        text.GetComponent<TMPro.TextMeshProUGUI>().text =                            "De jour comme de nuit <br>Hiver comme été<br>Chaud<br>Ombre<br>Végétaux<br>Soleil<br>Rafraichissant";

                    break;
                    case 12:
                        text.GetComponent<TMPro.TextMeshProUGUI>().text =                            "De jour comme de nuit <br>Hiver comme été<br>Chaud<br>Ombre<br>Végétaux<br>Soleil<br>Rafraichissant<br>Apaisant";

                        break;
                    case 13:
                        text.GetComponent<TMPro.TextMeshProUGUI>().text =                            "Sécurisant";

                        break;
                    case 14:
                        text.GetComponent<TMPro.TextMeshProUGUI>().text =                            "Sécurisant<br>Sombres";

                        break;

                    case 15:
                        text.GetComponent<TMPro.TextMeshProUGUI>().text =                            "Sécurisant<br>Sombres<br>Détécteurs de mouvements";

                        break;
                    case 16:
                        text.GetComponent<TMPro.TextMeshProUGUI>().text =                            "Sécurisant<br>Sombres<br>Détécteurs de mouvements <br>Eclairages diffus";

                        break;
                    case 17:
                        text.GetComponent<TMPro.TextMeshProUGUI>().text =                            "Sécurisant<br>Sombres<br>Détécteurs de mouvements <br>Eclairages diffus<br>Eclairage artificiel";

                        break;
                    case 18:
                        text.GetComponent<TMPro.TextMeshProUGUI>().text =                            "Sécurisant<br>Sombres <br>Détécteurs de mouvements <br>Eclairages diffus<br>Eclairage artificiel<br>Lampadaires \"Lucioles\"";

                        break;
                    case 19:
                        text.GetComponent<TMPro.TextMeshProUGUI>().text =                            "Sécurisant<br>Sombres<br>Détécteurs de mouvements <br>Eclairages diffus<br>Eclairage artificiel<br>Lampadaires \"Lucioles\"<br>Respact de la  biodiversité";

                        break;

                    default:
                        text.GetComponent<TMPro.TextMeshProUGUI>().text = "";
                        break;
            }

            
            
        }

        
        if(Input.GetKeyDown(KeyCode.P))
        {
            player.GetComponent<CharacterMovement>().enabled = false;
            player.GetComponent<MeshRenderer>().enabled = false;
            if (!_isDissapearing)
            {
               
                player = Instantiate(playerPrefab, player.transform.position, Quaternion.identity);
                PlayersList.Add(player);


                switch(index)
                {
                    case 1:
                        player.GetComponent<TrailRenderer>().startColor = Color.cyan;
                        player.GetComponent<TrailRenderer>().endColor = Color.cyan;        
                        text.GetComponent<TMPro.TextMeshProUGUI>().color = Color.cyan;
                        player.GetComponent<MeshRenderer>().material.color = Color.cyan;
                        break;
  
                    case 2:
                        player.GetComponent<TrailRenderer>().startColor = Color.red;
                        player.GetComponent<TrailRenderer>().endColor = Color.red;   
                        text.GetComponent<TMPro.TextMeshProUGUI>().color = Color.red;
                        player.GetComponent<MeshRenderer>().material.color = Color.red;


                        break;
                    case 3:
                        player.GetComponent<TrailRenderer>().startColor = Color.yellow;
                        player.GetComponent<TrailRenderer>().endColor = Color.yellow;  
                        text.GetComponent<TMPro.TextMeshProUGUI>().color = Color.yellow;
                        player.GetComponent<MeshRenderer>().material.color = Color.yellow;

                        break;
                    case 4:
           
                        
                        text.GetComponent<TMPro.TextMeshProUGUI>().text = "";
                        foreach (GameObject player in PlayersList)
                        {
                            GameObject.Destroy(player);
                        }
                        player = Instantiate(playerPrefab, player.transform.position, Quaternion.identity);
                        player.GetComponent<TrailRenderer>().startColor = new Color(1,0,1);
                        player.GetComponent<TrailRenderer>().endColor = new Color(1,0,1);
                        player.GetComponent<MeshRenderer>().material.color = new Color(1,0,1);



                        break;
                    default: 
                        break;
                }

                player.GetComponent<TrailRenderer>().enabled = true;
                _isDissapearing = true;
            }
            else
            {
                player = Instantiate(playerPrefab, player.transform.position, Quaternion.identity);
                player.GetComponent<TrailRenderer>().enabled = false;
                _isDissapearing = false;
            }
        }
    }
}
