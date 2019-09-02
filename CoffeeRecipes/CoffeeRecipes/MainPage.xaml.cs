using System;
using System.ComponentModel;
using Xamarin.Forms;

namespace CoffeeRecipes
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Btn_Clicked(object sender, EventArgs e)
        {
            var imageButton = sender as ImageButton;

            switch (imageButton.AutomationId)
            {
                case "espresso":
                    DisplayAlert("ESPRESSO", "∙ Espresso 30 mL" +
                                            "\n∙ Crema", "OK");
                    break;
                case "doppio":
                    DisplayAlert("DOPPIO", "∙ Espresso 60 mL" +
                                            "\n∙ Crema", "OK");
                    break;
                case "macchiato":
                    DisplayAlert("MACCHIATO", "∙ Espresso 60 mL" +
                                            "\n∙ Crema" +
                                            "\n∙ Dot of Foamed Milk", "OK");
                    break;
                case "cafe_creme":
                    DisplayAlert("CAFÉ CREME", "∙ Espresso 60 mL" +
                                            "\n∙ Crema" +
                                            "\n∙ Heavy Cream 30 mL", "OK");
                    break;
                case "cappuccino":
                    DisplayAlert("CAPPUCCINO", "∙ Espresso 60 mL" +
                                            "\n∙ Crema" +
                                            "\n∙ Steamed Milk 60 mL" +
                                            "\n∙ Foamed Milk 60 mL", "OK");
                    break;
                case "americano":
                    DisplayAlert("AMERICANO", "∙ Espresso 60 mL" +
                                            "\n∙ Crema" +
                                            "\n∙ Hot Water 90 mL", "OK");
                    break;
                case "affogato":
                    DisplayAlert("AFFOGATO", "∙ Vanilla Ice Cream 90 mL" +
                                            "\n∙ Espresso 60 mL" +
                                            "\n∙ Crema", "OK");
                    break;
                case "breve":
                    DisplayAlert("BREVE", "∙ Espresso 60 mL" +
                                            "\n∙ Crema" +
                                            "\n∙ Half & Half 90 mL", "OK");
                    break;
                case "mocha":
                    DisplayAlert("MOCHA", "∙ Espresso 60 mL" +
                                            "\n∙ Crema" +
                                            "\n∙ Chocolate 60 mL" +
                                            "\n∙ Steamed Milk 30 mL", "OK");
                    break;
                case "cafe_con_hielo":
                    DisplayAlert("CAFÉ CON HIELO", "∙ Espresso 60 mL" +
                                            "\n∙ Crema" +
                                            "\n∙ Ice Cubes", "OK");
                    break;
                case "flat_white":
                    DisplayAlert("FLAT WHITE", "∙ Espresso 60 mL" +
                                            "\n∙ Crema" +
                                            "\n∙ Steamed Milk 120 mL", "OK");
                    break;
                case "black_eye":
                    DisplayAlert("BLACK EYE", "∙ Espresso 60 mL" +
                                            "\n∙ Crema" +
                                            "\n∙ Brewed Coffee 120 mL", "OK");
                    break;
                case "latte":
                    DisplayAlert("LATTE", "∙ Espresso 60 mL" +
                                            "\n∙ Crema" +
                                            "\n∙ Steamed Milk 300 mL" +
                                            "\n∙ Foamed Milk 2 mL", "OK");
                    break;
                case "double_latte":
                    DisplayAlert("DOUBLE LATTE", "∙ Espresso 120 mL" +
                                            "\n∙ Crema" +
                                            "\n∙ Steamed Milk 240 mL" +
                                            "\n∙ Foamed Milk 2 mL", "OK");
                    break;
            }
        }
    }
}
