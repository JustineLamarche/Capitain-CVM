using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class MainMenuButtonAction : MonoBehaviour
{
    public Button ButtonNiv2;
    public Button ButtonNiv3;

    public TextMeshProUGUI TextCarte;
    public TextMeshProUGUI TextPoussins;
    public TextMeshProUGUI TextGrains;
    /// <summary>
    /// Permet d'afficher un panel transmis en paramètre
    /// </summary>
    /// <param name="PanelAOuvrir">Panel à afficher</param>
    public void AfficherPanel(GameObject PanelAOuvrir)
    {
        PanelAOuvrir.SetActive(true);

        /// <summary>
        /// Permet de cliquer sur le bouton si le niveau du joueur le permet
        /// </summary>
        if(GameManager.Instance.PlayerData.Niveau >= 2) {
            ButtonNiv2.interactable = true;
        }
        if(GameManager.Instance.PlayerData.Niveau >= 3) {
            ButtonNiv3.interactable = true;
        }

        TextCarte.text = GameManager.Instance.PlayerData.Carte.ToString();
        TextPoussins.text = GameManager.Instance.PlayerData.Poussin.ToString();
        TextGrains.text = GameManager.Instance.PlayerData.Grain.ToString();
    }

    /// <summary>
    /// Permet de ferme aussi le panel actuel
    /// </summary>
    /// <param name="PanelAFermer">Panel à fermer</param>
    public void FermerPanel(GameObject PanelAFermer)
    {
        PanelAFermer.SetActive(false);
    }

    /// <summary>
    /// Permet de charger un niveau
    /// </summary>
    /// <param name="nom">Nom du niveau à charger</param>
    public void ChargerNiveau(string nom)
    {
        SceneManager.LoadScene(nom);
    }

    /// <summary>
    /// Permet de fermer l'application
    /// </summary>
    public void Quitter()
    {
        Application.Quit();
    }
}
