/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SeletorDeEnigma : MonoBehaviour
{
    [SerializeField] ListaDeEnigmas lista;
    [SerializeField] Text perguntaTexto;
    [SerializeField] Text botao1Texto;
    [SerializeField] Text botao2Texto;
    [SerializeField] Text botao3Texto;
    [SerializeField] Text botao4Texto;
    [SerializeField] Text scoreTexto;
    [SerializeField] Text recordTexto;
    [SerializeField] Dificuldade dropdown;



    List<string> respostasPossiveis = new List<string>();
    int index;
    int score;
    int record;
    int dificuldade;

    void Start()
    {

        List<Enigma> listaTemp = Dificuldade();


        scoreTexto.text = "Score: " + score.ToString();
        record = PlayerPrefs.GetInt("record", 0);
        recordTexto.text = "record: " + record.ToString();

        index = Random.Range(0, lista.listaDeEnigmas.Count);

        respostasPossiveis.Add(lista.listaDeEnigmas[index].respostaCorreta);
        respostasPossiveis.Add(lista.listaDeEnigmas[index].respostaErrada1);
        respostasPossiveis.Add(lista.listaDeEnigmas[index].respostaErrada2);
        respostasPossiveis.Add(lista.listaDeEnigmas[index].respostaErrada3);



        int indexRespostas = Random.Range(0, respostasPossiveis.Count);



        perguntaTexto.text = lista.listaDeEnigmas[index].pergunta;

        botao1Texto.text = respostasPossiveis[indexRespostas];
        respostasPossiveis.Remove(respostasPossiveis[indexRespostas]);
        indexRespostas = Random.Range(0, respostasPossiveis.Count);


        botao2Texto.text = respostasPossiveis[indexRespostas];
        respostasPossiveis.Remove(respostasPossiveis[indexRespostas]);
        indexRespostas = Random.Range(0, respostasPossiveis.Count);


        botao3Texto.text = respostasPossiveis[indexRespostas];
        respostasPossiveis.Remove(respostasPossiveis[indexRespostas]);
        indexRespostas = Random.Range(0, respostasPossiveis.Count);

        botao4Texto.text = respostasPossiveis[indexRespostas];
        respostasPossiveis.Remove(respostasPossiveis[indexRespostas]);

    }
    
    public void OnClick(Text TextoBotao)
	{

        List<Enigma> listaTemp = Dificuldade();

        if (TextoBotao.text == lista.listaDeEnigmas[index].respostaCorreta)
		{
            lista.listaDeEnigmas.Remove(lista.listaDeEnigmas[index]);
            score = score + 5;
            scoreTexto.text = "Score: " + score.ToString();
            Start();
            if (score > record)
			{
                record = score;
                recordTexto.text = "Record: " + score.ToString();
                PlayerPrefs.SetInt("record", record);
            }
		}
        else
		{
            Debug.Log("Resposta Errada");
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
	}
    

}
*/


using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SeletorDeEnigma : MonoBehaviour
{
    [SerializeField] ListaDeEnigmas lista;
    [SerializeField] Dificuldade dropdown;
    [SerializeField] Text perguntaTexto;
    [SerializeField] Text botao1Texto;
    [SerializeField] Text botao2Texto;
    [SerializeField] Text botao3Texto;
    [SerializeField] Text botao4Texto;
    [SerializeField] Text scoreTexto;
    [SerializeField] Text recordTexto;
    List<string> repostasPossiveis = new List<string>();
    int score;
    int record;
    int index;
    int indexRespostas;
    int dificuldade;
   public GameObject win;


    void Start()
    {
        Screen.SetResolution(1024, 800, false);

        scoreTexto.text = "Score: " + score.ToString();
        //pegar a variavel armazenada no pc e setar o valor no record / case null
        record = PlayerPrefs.GetInt("record", 0);
        recordTexto.text = "Record: " + record.ToString();

        //pegar a variavel dificuldade do dropdown
        dificuldade = dropdown.dificuldade;

        //Função para selecionar a dificuldade
        List<Enigma> listaTemp = Dificuldade();

        //Função para inserir as questoes na tela, conforme a dificuldade
        QuestoesAleatorias(listaTemp);
    }

    //Função para retornar a dificuldade das questoes
    public List<Enigma> Dificuldade()
    {
        //setar dificuldade
        switch (dificuldade)
        {
            case 0:
                Debug.Log("Easy");
                return lista.listaDeEnigmas;
            case 1:
                Debug.Log("Medium");
                return lista.listaDeEnigmasMedio;
            case 2:
                Debug.Log("Hard");
                return lista.listaDeEnigmasDificil;
        }
        return lista.listaDeEnigmas;
    }

    public void QuestoesAleatorias(List<Enigma> lista)
    {
        //aleatorio para posição das questoes
        index = Random.Range(0, lista.Count);

        //add na lista de repostas possiveis
        //adicionar na lista as questoes
        repostasPossiveis.Add(lista[index].respostaCorreta);
        repostasPossiveis.Add(lista[index].respostaErrada1);
        repostasPossiveis.Add(lista[index].respostaErrada2);
        repostasPossiveis.Add(lista[index].respostaErrada3);

        //=======================================================

        //aleatorio para inserir os textos nos botoes
        indexRespostas = Random.Range(0, repostasPossiveis.Count);

        //inserindo os textos nos botoes
        perguntaTexto.text = lista[index].pergunta;

        botao1Texto.text = repostasPossiveis[indexRespostas];
        repostasPossiveis.Remove(repostasPossiveis[indexRespostas]);
        indexRespostas = Random.Range(0, repostasPossiveis.Count);

        botao2Texto.text = repostasPossiveis[indexRespostas];
        repostasPossiveis.Remove(repostasPossiveis[indexRespostas]);
        indexRespostas = Random.Range(0, repostasPossiveis.Count);

        botao3Texto.text = repostasPossiveis[indexRespostas];
        repostasPossiveis.Remove(repostasPossiveis[indexRespostas]);
        indexRespostas = Random.Range(0, repostasPossiveis.Count);

        botao4Texto.text = repostasPossiveis[indexRespostas];
        repostasPossiveis.Remove(repostasPossiveis[indexRespostas]);

    }

    public void Score()
    {
        //verifica a dificuldade e soma o valor do score
        switch (dificuldade)
        {
            case 0:
                score = score + 5;
                break;
            case 1:
                score = score + 10;
                break;
            case 2:
                score = score + 15;
                break;
        }

        //insere o texto na tela
        scoreTexto.text = "Score: " + score.ToString();

        //verifica se o score é maior que o record e atualiza
        if (score > record)
        {
            record = score;
            recordTexto.text = "Record: " + record.ToString();
            //salvar um valor no texto record - cache do pc
            PlayerPrefs.SetInt("record", record);
        }

    }

    public void OnClick(Text TextoBotao)
    {
        List<Enigma> listaTemp = Dificuldade();

        if (TextoBotao.text == listaTemp[index].respostaCorreta)
        {
            //remove a questao da lista quando acerta
            listaTemp.Remove(listaTemp[index]);
            Score();
          /*  //condição para aparecer que acabou as questões
            if (listaTemp.Count == 0)
            {
                //Aparecer botão de vitória
                win.SetActive(true);
            }
            else
            {
                Start();
            }*/

        }
        else
        {
            //Resetar a cena
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }

    public void PowerUp()
    {
        List<Enigma> listaTemp = Dificuldade();

        //remove a questao da lista quando acerta
        listaTemp.Remove(listaTemp[index]);
        Score();
        
        /*
        
        //condição para aparecer que acabou as questões
        if (listaTemp.Count == 0)
        {
            //Aparecer botão de vitória
            win.SetActive(true);
        }
        else
        {
            Start();
        } */
    }

    //Ao clicar que venceu
    public void OnclickWin()
    {
        //Resetar a cena
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}