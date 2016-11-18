using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace ComandaSmatphone
{
    [Activity()]
    public class TelaDeCadastro : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.CadastroDeItens);
            this.ActionBar.SetDisplayHomeAsUpEnabled(true);
            // FindViewById<Button>(Resource.Id.btnEstabelecimento).Click += TelaDeCadastroClick(); 
        }

        public override bool OnOptionsItemSelected(IMenuItem item)
        {
            switch (item.ItemId)
            {

                case Android.Resource.Id.Home:
                    Finish();
                    return true;
                default:
                    return base.OnOptionsItemSelected(item);
            }
        }
    }
}