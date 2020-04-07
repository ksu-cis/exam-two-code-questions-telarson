using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using ExamTwoCodeQuestions.Data;

namespace ExamTwoQuestions.PointOfSale
{
    /// <summary>
    /// Interaction logic for CustomizeCobblerControl.xaml
    /// </summary>
    public partial class CustomizeCobblerControl : UserControl
    {
        public CustomizeCobblerControl()
        {
            InitializeComponent();

            //Scale up the CheckBox and ComboBox to be more useable with a touch screen
            ScaleTransform scale = new ScaleTransform(2.0, 2.0);
            WithIceCreamCheckBox.RenderTransform = scale;
            FruitFillingComboBox.RenderTransform = scale;

            //Get the Enum values and set them as the item source for the FruitFillingComboBox
            FruitFillingComboBox.ItemsSource = Enum.GetValues(typeof(FruitFilling));

        }

    }
}
