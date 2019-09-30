using System;
using System.Collections.Generic;
using System.Diagnostics;
using Xamarin.Forms;

namespace Trady.Controls
{
    public partial class ItemCell : ViewCell
    {
        public ItemCell()
        {
            InitializeComponent();
        }

        //#region "ID BindableProperty"
        //public static readonly BindableProperty IDProperty =
        //    BindableProperty.Create(
        //        "ID",
        //        typeof(int),
        //        typeof(ItemCell),
        //        -1);
        //public int ID
        //{
        //    get { return (int)GetValue(IDProperty); }
        //    set { SetValue(IDProperty, value); }
        //}
        //#endregion

        #region "Information BindableProperty"
        public static readonly BindableProperty InformationProperty =
            BindableProperty.Create(
                "Information",
                typeof(string),
                typeof(ItemCell),
                null);
        public string Information
        {
            get { return (string)GetValue(InformationProperty); }
            set { SetValue(InformationProperty, value); }
        }
        #endregion

        #region "Photo BindableProperty"
        public static readonly BindableProperty PhotoProperty =
            BindableProperty.Create(
                "Photo",
                typeof(ImageSource),
                typeof(ItemCell),
                null);
        public ImageSource Photo
        {
            get { return (ImageSource)GetValue(PhotoProperty); }
            set { SetValue(PhotoProperty, value); }
        }
        #endregion

        #region "Category BindableProperty"
        public static readonly BindableProperty CategoryProperty =
            BindableProperty.Create(
                "Category",
                typeof(string),
                typeof(ItemCell),
                null);
        public string Category
        {
            get { return (string)GetValue(CategoryProperty); }
            set { SetValue(CategoryProperty, value); }
        }
        #endregion

        #region "Date BindableProperty"
        public static readonly BindableProperty DateProperty =
            BindableProperty.Create(
                "Date",
                typeof(string),
                typeof(ItemCell),
                null);
        public string Date
        {
            get { return (string)GetValue(DateProperty); }
            set { SetValue(DateProperty, value); }
        }
        #endregion

        protected override void OnBindingContextChanged()
        {
            base.OnBindingContextChanged();

            if (BindingContext != null)
            {
                imgPhoto.Source = Photo;
                lblInformation.Text = Information;
                lblCategory.Text = Category;
                lblDate.Text = Date;
            }
        }

        public void OnMore_Click(object sender, EventArgs e)
        {
            Debug.WriteLine("OnMore_Click ID:{0}", Date);
        }

        public void OnDelete_Click(object sender, EventArgs e)
        {
            Debug.WriteLine("OnDelete_Click ID:{0}", Date);
        }
    }
}
