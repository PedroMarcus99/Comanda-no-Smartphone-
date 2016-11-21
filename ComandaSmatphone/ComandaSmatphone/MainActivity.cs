using Android.App;
using Android.Widget;
using Android.OS;
using System;
using Android.Content;
using Android.Runtime;
using Android.Views;
using System.Collections.Generic;
using System.IO;
using System.Linq;


namespace ComandaSmatphone
{
    [Activity(Label = "Comanda no Smatphone", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        GerenciaListaDeNovosItens utiliza_Lista; 
        List<string> itens_na_comanda; // Aqui inicia a lista de itens para o estabelecimento adicionar. 
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
           // Button button = FindViewById<Button>(Resource.Id.btnEstabelecimento);          
            //button.Click += delegate { button.Text = string.Format("{0} clicks!", count++); };
            // Set our view from the "main" layout resource
            SetContentView (Resource.Layout.Main);

            /*
            //Aqui é instanciado o botão a ser utilizado para a exibição da mensagem de confirmação!
            Button mensagem = FindViewById<Button>(Resource.Id.btnConfirmaDefinicao);
            mensagem.Click += delegate
            {
                //Aqui se define o início de uma mensagem a ser exibida. 
                AlertDialog.Builder mensagem_exibida = new AlertDialog.Builder(this);
                AlertDialog alerta = mensagem_exibida.Create();
                //Aqui se inicia a mensagem a ser exibida.
                alerta.SetTitle("Informação:");
                alerta.SetIcon(Android.Resource.Drawable.AlertLightFrame);
                alerta.SetMessage("Suas informações foram definidas com sucesso!");

                alerta.SetButton("Ok", (s, ev) =>
                {
                    Toast.MakeText(this, "Certo. Vamos lá!", ToastLength.Short).Show();
                });
                alerta.Show();
                //Fim da exibição da mensage. 
            }; 

            
            //Abaixo o código para salvar ou não a alteração. 
            Button salva_confirmacao = FindViewById<Button>(Resource.Id.btnConfirmaDefinicao);
            salva_confirmacao.Click += delegate
            {
                //define o alerta para executar o comando. 
                AlertDialog.Builder alerta_de_confirmacao= new AlertDialog.Builder(this);
                //define  o titulo da mensagem.
                alerta_de_confirmacao.SetTitle("Aviso: ");
                alerta_de_confirmacao.SetIcon(Android.Resource.Drawable.IcInputAdd);
                //define mensagem
                alerta_de_confirmacao.SetMessage("Deseja realmente salvar as alterações?");
                //define os botões disponíveis para a confiração.  
                //Botão positivo. 
                alerta_de_confirmacao.SetPositiveButton("Salvar", (senderAlert, args) =>
                {
                    Toast.MakeText(this, "Informações salvas com sucesso!", ToastLength.Short).Show();
                });
                //Botão negativo. 
                alerta_de_confirmacao.SetNegativeButton("Cancelar", (senderAlert, e) =>
                {
                    Toast.MakeText(this, "Cancelado com sucesso!", ToastLength.Short).Show();
                });
                //Cria alerta e exibe. 
                Dialog dialogo = alerta_de_confirmacao.Create();
                dialogo.Show(); 

            }; */


            FindViewById<Button>(Resource.Id.btnConfigura).Click += NovoCartaoCadastrado; // abre a tela de configuração de contas.. 
            FindViewById<Button>(Resource.Id.btnOutroCartao).Click += NovoCartaoCadastrado; // Abre a tela de configuraçaõ de contas.. 
            FindViewById<Button>(Resource.Id.btnSaldo).Click += PagamentoDaConta; // Abre a tela de comanda para o pagamento.. 
            FindViewById<Button>(Resource.Id.btnCartaoCadastrado).Click += PagamentoDaConta; //Abre a tela de comanda para o pagamento.. 



            itens_na_comanda = new List<string>(); //Instancia a lista de dados para a comanda..
            itens_na_comanda.Add("Teste 0"); // + preco_produto
            itens_na_comanda.Add("Teste 1");
            itens_na_comanda.Add("Teste 2");
            itens_na_comanda.Add("Teste 3");
            itens_na_comanda.Add("Teste 4");
            itens_na_comanda.Add("Teste 5");
            itens_na_comanda.Add("Teste 6");
            itens_na_comanda.Add("Teste 7");
            itens_na_comanda.Add("Teste 8");
            itens_na_comanda.Add("Teste 9");

           // ListView List = FindViewById<ListView>(Resource.Id.listaDados);


            utiliza_Lista = new GerenciaListaDeNovosItens(itens_na_comanda, this);
          //  List.Adapter = utiliza_Lista;
          // List.ItemClick += List_ItemClick; 
            //Fim da lista. 
             
        }

        void MensagemDeDefinicao(object sender, AdapterView.ItemClickEventArgs e)
        {
            Toast.MakeText(this, "Suas informações foram alteradas com sucesso!", ToastLength.Long).Show(); 
        }

        void List_ItemClick(object sender, AdapterView.ItemClickEventArgs e)
        {
            Toast.MakeText(this, itens_na_comanda[e.Position], ToastLength.Short).Show();
        }

        void NovoCartaoCadastrado(object sender, EventArgs e)
        {
            // nova pagina
            var myIntent = new Intent(this, typeof(ConfiguraCartao));
            StartActivityForResult(myIntent, 0);
        }
        void PagamentoDaConta(object sender, EventArgs e)
        {
            //Nova tala de pagamento
            var myIntent = new Intent(this, typeof(PagamentoDaConta));
            StartActivityForResult(myIntent, 0); 
        }
    }
}

