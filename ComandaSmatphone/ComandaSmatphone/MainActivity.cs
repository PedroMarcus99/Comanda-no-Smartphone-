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
using Android.Locations;

namespace ComandaSmatphone
{
    [Activity(Label = "Comanda no Smatphone", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        //GerenciaListaDeNovosItens utiliza_Lista; 
        List<string> itens_na_comanda; // Aqui inicia a lista de itens para o estabelecimento adicionar. 
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            //Button button = FindViewById<Button>(Resource.Id.button1);

            //button.Click += delegate { button.Text = string.Format("{0} clicks!", count++); };
            // Set our view from the "main" layout resource
             SetContentView (Resource.Layout.Main);

            itens_na_comanda = new List<string>(); //Instancia a lista de dados para a comanda..
            itens_na_comanda.Add("Teste para implementação App / 1"); // + preco_produto
            itens_na_comanda.Add("Teste para implementação App / 2");
            itens_na_comanda.Add("Teste para implementação App / 3");
            itens_na_comanda.Add("Teste para implementação App / 4");

            ListView List = FindViewById<ListView>(Resource.Id.listaDados);


            GerenciaListaDeNovosItens GL = new GerenciaListaDeNovosItens(itens_na_comanda, this);
            List.Adapter = GL;
            List.ItemClick += List_ItemClick; 
            //Fim da lista. 
             
        }

        void List_ItemClick(object sender, AdapterView.ItemClickEventArgs e)
        {
            Toast.MakeText(this, itens_na_comanda[e.Position], ToastLength.Short).Show();
        }
    }
}

