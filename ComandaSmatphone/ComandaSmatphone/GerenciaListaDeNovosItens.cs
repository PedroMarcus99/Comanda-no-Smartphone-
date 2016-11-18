using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Java.Lang;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ComandaSmatphone
{
    public class GerenciaListaDeNovosItens : BaseAdapter<string>
    {
        List<string> itens_na_comanda;
        Activity recebe_definicao;

        public GerenciaListaDeNovosItens(List<string> novo_item_inserido, Activity nova_definicao)
        {
            itens_na_comanda = novo_item_inserido;
            recebe_definicao = nova_definicao;
        }
        public override string this[int position]
        {
            get
            {
                return itens_na_comanda[position];
            }
        }
        public override int Count
        {
            get
            {
                return itens_na_comanda.Count;
            }
        }
        public override long GetItemId(int position)
        {
            return position; 
        }

        public  override View GetView(int position, View convertView, ViewGroup parent)
        {
            //throw new NotImplementedException();
            View view = convertView;
            if (view == null)
                view = recebe_definicao.LayoutInflater.Inflate(Resource.Layout.ComandaParaCliente, null);
            view.FindViewById<TextView>(Resource.Id.textLabel).Text = itens_na_comanda[position];
            return view; 
        }
    }
}