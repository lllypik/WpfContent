using System;
using System.Windows;

namespace WpfContent
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        // пробовал выполнить метод через void и возвращал числом результат, но не получается обратиться напрямую к строке в окне с текстом
        //private void ConvertCurrency(in object Text1, in object Text2, in object Text3)
        //{
        //    double ratUE = Convert.ToDouble(Text1.Text);
        //    double sumUE = Convert.ToDouble(Text2.Text);
        //    double resultUE = ratUE * sumUE;
        //    Text3.Text = resultUE.ToString();
        //}

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double ratUE = Convert.ToDouble(rateUE.Text);
            double sumUE = Convert.ToDouble(summUE.Text);
            double resultUE = ratUE * sumUE;
            resUE.Text = resultUE.ToString();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            double ratGR = Convert.ToDouble(rateGR.Text);
            double sumGR = Convert.ToDouble(summGR.Text);
            double resultGR = ratGR * sumGR;
            resGR.Text = resultGR.ToString();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            double ratEU = Convert.ToDouble(rateEU.Text);
            double sumEU = Convert.ToDouble(summEU.Text);
            double resultEU = ratEU * sumEU;
            resEU.Text = resultEU.ToString();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            double ratLR = Convert.ToDouble(rateLR.Text);
            double sumLR = Convert.ToDouble(summLR.Text);
            double resultLR = ratLR * sumLR;
            resLR.Text = resultLR.ToString();
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            double numbI = Convert.ToDouble(numIn.Text);
            double resultI = numbI * 0.0254;
            resIn.Text = resultI.ToString();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            double numbF = Convert.ToDouble(numF.Text);
            double resultF = numbF * 0.3048;
            resF.Text = resultF.ToString();
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            double numbM = Convert.ToDouble(numM.Text);
            double resultM = numbM * 1609.3;
            resM.Text = resultM.ToString();
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            double numbV = Convert.ToDouble(numV.Text);
            double resultV = numbV * 1066.7;
            resV.Text = resultV.ToString();
        }
    }
}
