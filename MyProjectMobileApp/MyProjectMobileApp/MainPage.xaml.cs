using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MyProjectMobileApp
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        private static int clickCount;
        private static object _sender;

        public MainPage()
        {
            InitializeComponent();
        }

        private void first_Clicked(object sender, EventArgs e)
        {
            //firstButton.BackgroundColor = Color.Yellow;
            if (clickCount < 1)
            {
                TimeSpan tt = new TimeSpan(0, 0, 0, 0, 250);
                _sender = sender;
                Device.StartTimer(tt, ClickHandle);
            }
            clickCount++;
        }//end first_clicked
        bool ClickHandle()
        {
            if (clickCount > 1)
            {
                firstButton.BackgroundColor = Color.Red;
            }
            else
            {
                firstButton.BackgroundColor = Color.Yellow;
            }
            clickCount = 0;
            _sender = null;
            return false;
        }//end clickHandle


        //Button 2
        private void second_Clicked(object sender, EventArgs e)
        {
            //firstButton.BackgroundColor = Color.Yellow;
            if (clickCount < 1)
            {
                TimeSpan tt = new TimeSpan(0, 0, 0, 0, 250);
                _sender = sender;
                Device.StartTimer(tt, ClickHandle2);
            }
            clickCount++;
        }//end first_clicked
        bool ClickHandle2()
        {
            if (clickCount > 1)
            {
                secondButton.BackgroundColor = Color.Red;
            }
            else
            {
                secondButton.BackgroundColor = Color.Yellow;
            }
            clickCount = 0;
            _sender = null;
            return false;
        }//end clickHandle

        //Button 3
        private void third_Clicked(object sender, EventArgs e)
        {
            //firstButton.BackgroundColor = Color.Yellow;
            if (clickCount < 1)
            {
                TimeSpan tt = new TimeSpan(0, 0, 0, 0, 250);
                _sender = sender;
                Device.StartTimer(tt, ClickHandle3);
            }
            clickCount++;
        }//end first_clicked
        bool ClickHandle3()
        {
            if (clickCount > 1)
            {
                thirdButton.BackgroundColor = Color.Red;
            }
            else
            {
                thirdButton.BackgroundColor = Color.Yellow;
            }
            clickCount = 0;
            _sender = null;
            return false;
        }//end clickHandle

        //Button 4
        private void fourth_Clicked(object sender, EventArgs e)
        {
            //firstButton.BackgroundColor = Color.Yellow;
            if (clickCount < 1)
            {
                TimeSpan tt = new TimeSpan(0, 0, 0, 0, 250);
                _sender = sender;
                Device.StartTimer(tt, ClickHandle4);
            }
            clickCount++;
        }//end first_clicked
        bool ClickHandle4()
        {
            if (clickCount > 1)
            {
                fourthButton.BackgroundColor = Color.Red;
            }
            else
            {
                fourthButton.BackgroundColor = Color.Yellow;
            }
            clickCount = 0;
            _sender = null;
            return false;
        }//end clickHandle

        //Button 5
        private void fifth_Clicked(object sender, EventArgs e)
        {
            //firstButton.BackgroundColor = Color.Yellow;
            if (clickCount < 1)
            {
                TimeSpan tt = new TimeSpan(0, 0, 0, 0, 250);
                _sender = sender;
                Device.StartTimer(tt, ClickHandle5);
            }
            clickCount++;
        }//end first_clicked
        bool ClickHandle5()
        {
            if (clickCount > 1)
            {
                fifthButton.BackgroundColor = Color.Red;
            }
            else
            {
                fifthButton.BackgroundColor = Color.Yellow;
            }
            clickCount = 0;
            _sender = null;
            return false;
        }//end clickHandle


        //Button 6
        private void sixth_Clicked(object sender, EventArgs e)
        {
            //firstButton.BackgroundColor = Color.Yellow;
            if (clickCount < 1)
            {
                TimeSpan tt = new TimeSpan(0, 0, 0, 0, 250);
                _sender = sender;
                Device.StartTimer(tt, ClickHandle6);
            }
            clickCount++;
        }//end first_clicked
        bool ClickHandle6()
        {
            if (clickCount > 1)
            {
                sixthButton.BackgroundColor = Color.Red;
            }
            else
            {
                sixthButton.BackgroundColor = Color.Yellow;
            }
            clickCount = 0;
            _sender = null;
            return false;
        }//end clickHandle

        //Button 7
        private void seventh_Clicked(object sender, EventArgs e)
        {
            //firstButton.BackgroundColor = Color.Yellow;
            if (clickCount < 1)
            {
                TimeSpan tt = new TimeSpan(0, 0, 0, 0, 250);
                _sender = sender;
                Device.StartTimer(tt, ClickHandle7);
            }
            clickCount++;
        }//end first_clicked
        bool ClickHandle7()
        {
            if (clickCount > 1)
            {
                seventhButton.BackgroundColor = Color.Red;
            }
            else
            {
                seventhButton.BackgroundColor = Color.Yellow;
            }
            clickCount = 0;
            _sender = null;
            return false;
        }//end clickHandle



        //Button 8
        private void eigth_Clicked(object sender, EventArgs e)
        {
            //firstButton.BackgroundColor = Color.Yellow;
            if (clickCount < 1)
            {
                TimeSpan tt = new TimeSpan(0, 0, 0, 0, 250);
                _sender = sender;
                Device.StartTimer(tt, ClickHandle8);
            }
            clickCount++;
        }//end first_clicked
        bool ClickHandle8()
        {
            if (clickCount > 1)
            {
                eigthButton.BackgroundColor = Color.Red;
            }
            else
            {
                eigthButton.BackgroundColor = Color.Yellow;
            }
            clickCount = 0;
            _sender = null;
            return false;
        }//end clickHandle



        //Button 9
        private void ninth_Clicked(object sender, EventArgs e)
        {
            //firstButton.BackgroundColor = Color.Yellow;
            if (clickCount < 1)
            {
                TimeSpan tt = new TimeSpan(0, 0, 0, 0, 250);
                _sender = sender;
                Device.StartTimer(tt, ClickHandle9);
            }
            clickCount++;
        }//end first_clicked
        bool ClickHandle9()
        {
            if (clickCount > 1)
            {
                ninthButton.BackgroundColor = Color.Red;
            }
            else
            {
                ninthButton.BackgroundColor = Color.Yellow;
            }
            clickCount = 0;
            _sender = null;
            return false;
        }//end clickHandle

        //Button 10
        private void tenth_Clicked(object sender, EventArgs e)
        {
            //firstButton.BackgroundColor = Color.Yellow;
            if (clickCount < 1)
            {
                TimeSpan tt = new TimeSpan(0, 0, 0, 0, 250);
                _sender = sender;
                Device.StartTimer(tt, ClickHandle10);
            }
            clickCount++;
        }//end first_clicked
        bool ClickHandle10()
        {
            if (clickCount > 1)
            {
                tenthButton.BackgroundColor = Color.Red;
            }
            else
            {
                tenthButton.BackgroundColor = Color.Yellow;
            }
            clickCount = 0;
            _sender = null;
            return false;
        }//end clickHandle

        //Button 11
        private void eleven_Clicked(object sender, EventArgs e)
        {
            //firstButton.BackgroundColor = Color.Yellow;
            if (clickCount < 1)
            {
                TimeSpan tt = new TimeSpan(0, 0, 0, 0, 250);
                _sender = sender;
                Device.StartTimer(tt, ClickHandle11);
            }
            clickCount++;
        }//end first_clicked
        bool ClickHandle11()
        {
            if (clickCount > 1)
            {
                elevenButton.BackgroundColor = Color.Red;
            }
            else
            {
                elevenButton.BackgroundColor = Color.Yellow;
            }
            clickCount = 0;
            _sender = null;
            return false;
        }//end clickHandle

        //Button 12
        private void twelve_Clicked(object sender, EventArgs e)
        {
            //firstButton.BackgroundColor = Color.Yellow;
            if (clickCount < 1)
            {
                TimeSpan tt = new TimeSpan(0, 0, 0, 0, 250);
                _sender = sender;
                Device.StartTimer(tt, ClickHandle12);
            }
            clickCount++;
        }//end first_clicked
        bool ClickHandle12()
        {
            if (clickCount > 1)
            {
                twelveButton.BackgroundColor = Color.Red;
            }
            else
            {
                twelveButton.BackgroundColor = Color.Yellow;
            }
            clickCount = 0;
            _sender = null;
            return false;
        }//end clickHandle

        //Button 13
        private void thirteen_Clicked(object sender, EventArgs e)
        {
            //firstButton.BackgroundColor = Color.Yellow;
            if (clickCount < 1)
            {
                TimeSpan tt = new TimeSpan(0, 0, 0, 0, 250);
                _sender = sender;
                Device.StartTimer(tt, ClickHandle13);
            }
            clickCount++;
        }//end first_clicked
        bool ClickHandle13()
        {
            if (clickCount > 1)
            {
                thirteenButton.BackgroundColor = Color.Red;
            }
            else
            {
                thirteenButton.BackgroundColor = Color.Yellow;
            }
            clickCount = 0;
            _sender = null;
            return false;
        }//end clickHandle

        //Button 14
        private void fourteen_Clicked(object sender, EventArgs e)
        {
            //firstButton.BackgroundColor = Color.Yellow;
            if (clickCount < 1)
            {
                TimeSpan tt = new TimeSpan(0, 0, 0, 0, 250);
                _sender = sender;
                Device.StartTimer(tt, ClickHandle14);
            }
            clickCount++;
        }//end first_clicked
        bool ClickHandle14()
        {
            if (clickCount > 1)
            {
                fourteenButton.BackgroundColor = Color.Red;
            }
            else
            {
                fourteenButton.BackgroundColor = Color.Yellow;
            }
            clickCount = 0;
            _sender = null;
            return false;
        }//end clickHandle

        //Button 15
        private void fifteen_Clicked(object sender, EventArgs e)
        {
            //firstButton.BackgroundColor = Color.Yellow;
            if (clickCount < 1)
            {
                TimeSpan tt = new TimeSpan(0, 0, 0, 0, 250);
                _sender = sender;
                Device.StartTimer(tt, ClickHandle15);
            }
            clickCount++;
        }//end first_clicked
        bool ClickHandle15()
        {
            if (clickCount > 1)
            {
                fifteenButton.BackgroundColor = Color.Red;
            }
            else
            {
                fifteenButton.BackgroundColor = Color.Yellow;
            }
            clickCount = 0;
            _sender = null;
            return false;
        }//end clickHandle


        //Button 16
        private void sixteen_Clicked(object sender, EventArgs e)
        {
            //firstButton.BackgroundColor = Color.Yellow;
            if (clickCount < 1)
            {
                TimeSpan tt = new TimeSpan(0, 0, 0, 0, 250);
                _sender = sender;
                Device.StartTimer(tt, ClickHandle16);
            }
            clickCount++;
        }//end first_clicked
        bool ClickHandle16()
        {
            if (clickCount > 1)
            {
                sixteenButton.BackgroundColor = Color.Red;
            }
            else
            {
                sixteenButton.BackgroundColor = Color.Yellow;
            }
            clickCount = 0;
            _sender = null;
            return false;
        }//end clickHandle


        //Button 17
        private void seventeen_Clicked(object sender, EventArgs e)
        {
            //firstButton.BackgroundColor = Color.Yellow;
            if (clickCount < 1)
            {
                TimeSpan tt = new TimeSpan(0, 0, 0, 0, 250);
                _sender = sender;
                Device.StartTimer(tt, ClickHandle17);
            }
            clickCount++;
        }//end first_clicked
        bool ClickHandle17()
        {
            if (clickCount > 1)
            {
                seventeenButton.BackgroundColor = Color.Red;
            }
            else
            {
                seventeenButton.BackgroundColor = Color.Yellow;
            }
            clickCount = 0;
            _sender = null;
            return false;
        }//end clickHandle


        //Button 18
        private void eighteen_Clicked(object sender, EventArgs e)
        {
            //firstButton.BackgroundColor = Color.Yellow;
            if (clickCount < 1)
            {
                TimeSpan tt = new TimeSpan(0, 0, 0, 0, 250);
                _sender = sender;
                Device.StartTimer(tt, ClickHandle18);
            }
            clickCount++;
        }//end first_clicked
        bool ClickHandle18()
        {
            if (clickCount > 1)
            {
                eighteenButton.BackgroundColor = Color.Red;
            }
            else
            {
                eighteenButton.BackgroundColor = Color.Yellow;
            }
            clickCount = 0;
            _sender = null;
            return false;
        }//end clickHandle


        //Button 19
        private void nineteen_Clicked(object sender, EventArgs e)
        {
            //firstButton.BackgroundColor = Color.Yellow;
            if (clickCount < 1)
            {
                TimeSpan tt = new TimeSpan(0, 0, 0, 0, 250);
                _sender = sender;
                Device.StartTimer(tt, ClickHandle19);
            }
            clickCount++;
        }//end first_clicked
        bool ClickHandle19()
        {
            if (clickCount > 1)
            {
                nineteenButton.BackgroundColor = Color.Red;
            }
            else
            {
                nineteenButton.BackgroundColor = Color.Yellow;
            }
            clickCount = 0;
            _sender = null;
            return false;
        }//end clickHandle

        //Button 20
        private void twenty_Clicked(object sender, EventArgs e)
        {
            //firstButton.BackgroundColor = Color.Yellow;
            if (clickCount < 1)
            {
                TimeSpan tt = new TimeSpan(0, 0, 0, 0, 250);
                _sender = sender;
                Device.StartTimer(tt, ClickHandle20);
            }
            clickCount++;
        }//end first_clicked
        bool ClickHandle20()
        {
            if (clickCount > 1)
            {
                twentyButton.BackgroundColor = Color.Red;
            }
            else
            {
                twentyButton.BackgroundColor = Color.Yellow;
            }
            clickCount = 0;
            _sender = null;
            return false;
        }//end clickHandle


        //Button 21
        private void twentyone_Clicked(object sender, EventArgs e)
        {
            //firstButton.BackgroundColor = Color.Yellow;
            if (clickCount < 1)
            {
                TimeSpan tt = new TimeSpan(0, 0, 0, 0, 250);
                _sender = sender;
                Device.StartTimer(tt, ClickHandle21);
            }
            clickCount++;
        }//end first_clicked
        bool ClickHandle21()
        {
            if (clickCount > 1)
            {
                twentyoneButton.BackgroundColor = Color.Red;
            }
            else
            {
                twentyoneButton.BackgroundColor = Color.Yellow;
            }
            clickCount = 0;
            _sender = null;
            return false;
        }//end clickHandle


        //Button 22
        private void twentytwo_Clicked(object sender, EventArgs e)
        {
            //firstButton.BackgroundColor = Color.Yellow;
            if (clickCount < 1)
            {
                TimeSpan tt = new TimeSpan(0, 0, 0, 0, 250);
                _sender = sender;
                Device.StartTimer(tt, ClickHandle22);
            }
            clickCount++;
        }//end first_clicked
        bool ClickHandle22()
        {
            if (clickCount > 1)
            {
                twentytwoButton.BackgroundColor = Color.Red;
            }
            else
            {
                twentytwoButton.BackgroundColor = Color.Yellow;
            }
            clickCount = 0;
            _sender = null;
            return false;
        }//end clickHandle


        //Button 23
        private void twentythree_Clicked(object sender, EventArgs e)
        {
            //firstButton.BackgroundColor = Color.Yellow;
            if (clickCount < 1)
            {
                TimeSpan tt = new TimeSpan(0, 0, 0, 0, 250);
                _sender = sender;
                Device.StartTimer(tt, ClickHandle23);
            }
            clickCount++;
        }//end first_clicked
        bool ClickHandle23()
        {
            if (clickCount > 1)
            {
                twentythreeButton.BackgroundColor = Color.Red;
            }
            else
            {
                twentythreeButton.BackgroundColor = Color.Yellow;
            }
            clickCount = 0;
            _sender = null;
            return false;
        }//end clickHandle



        //Button 24
        private void twentyfour_Clicked(object sender, EventArgs e)
        {
            //firstButton.BackgroundColor = Color.Yellow;
            if (clickCount < 1)
            {
                TimeSpan tt = new TimeSpan(0, 0, 0, 0, 250);
                _sender = sender;
                Device.StartTimer(tt, ClickHandle24);
            }
            clickCount++;
        }//end first_clicked
        bool ClickHandle24()
        {
            if (clickCount > 1)
            {
                twentyfourButton.BackgroundColor = Color.Red;
            }
            else
            {
                twentyfourButton.BackgroundColor = Color.Yellow;
            }
            clickCount = 0;
            _sender = null;
            return false;
        }//end clickHandle


        //Button 25
        private void twentyfive_Clicked(object sender, EventArgs e)
        {
            //firstButton.BackgroundColor = Color.Yellow;
            if (clickCount < 1)
            {
                TimeSpan tt = new TimeSpan(0, 0, 0, 0, 250);
                _sender = sender;
                Device.StartTimer(tt, ClickHandle25);
            }
            clickCount++;
        }//end first_clicked
        bool ClickHandle25()
        {
            if (clickCount > 1)
            {
                twentyfiveButton.BackgroundColor = Color.Red;
            }
            else
            {
                twentyfiveButton.BackgroundColor = Color.Yellow;
            }
            clickCount = 0;
            _sender = null;
            return false;
        }//end clickHandle

        //Button 26
        private void twentysix_Clicked(object sender, EventArgs e)
        {
            //firstButton.BackgroundColor = Color.Yellow;
            if (clickCount < 1)
            {
                TimeSpan tt = new TimeSpan(0, 0, 0, 0, 250);
                _sender = sender;
                Device.StartTimer(tt, ClickHandle26);
            }
            clickCount++;
        }//end first_clicked
        bool ClickHandle26()
        {
            if (clickCount > 1)
            {
                twentysixButton.BackgroundColor = Color.Red;
            }
            else
            {
                twentysixButton.BackgroundColor = Color.Yellow;
            }
            clickCount = 0;
            _sender = null;
            return false;
        }//end clickHandle

        //Button 27
        private void twentyseven_Clicked(object sender, EventArgs e)
        {
            //firstButton.BackgroundColor = Color.Yellow;
            if (clickCount < 1)
            {
                TimeSpan tt = new TimeSpan(0, 0, 0, 0, 250);
                _sender = sender;
                Device.StartTimer(tt, ClickHandle27);
            }
            clickCount++;
        }//end first_clicked
        bool ClickHandle27()
        {
            if (clickCount > 1)
            {
                twentysevenButton.BackgroundColor = Color.Red;
            }
            else
            {
                twentysevenButton.BackgroundColor = Color.Yellow;
            }
            clickCount = 0;
            _sender = null;
            return false;
        }//end clickHandle


        //Button 28
        private void twentyeight_Clicked(object sender, EventArgs e)
        {
            //firstButton.BackgroundColor = Color.Yellow;
            if (clickCount < 1)
            {
                TimeSpan tt = new TimeSpan(0, 0, 0, 0, 250);
                _sender = sender;
                Device.StartTimer(tt, ClickHandle28);
            }
            clickCount++;
        }//end first_clicked
        bool ClickHandle28()
        {
            if (clickCount > 1)
            {
                twentyeightButton.BackgroundColor = Color.Red;
            }
            else
            {
                twentyeightButton.BackgroundColor = Color.Yellow;
            }
            clickCount = 0;
            _sender = null;
            return false;
        }//end clickHandle

        //Button 29
        private void twentynine_Clicked(object sender, EventArgs e)
        {
            //firstButton.BackgroundColor = Color.Yellow;
            if (clickCount < 1)
            {
                TimeSpan tt = new TimeSpan(0, 0, 0, 0, 250);
                _sender = sender;
                Device.StartTimer(tt, ClickHandle29);
            }
            clickCount++;
        }//end first_clicked
        bool ClickHandle29()
        {
            if (clickCount > 1)
            {
                twentynineButton.BackgroundColor = Color.Red;
            }
            else
            {
                twentynineButton.BackgroundColor = Color.Yellow;
            }
            clickCount = 0;
            _sender = null;
            return false;
        }//end clickHandle


        //Button 30
        private void thirty_Clicked(object sender, EventArgs e)
        {
            //firstButton.BackgroundColor = Color.Yellow;
            if (clickCount < 1)
            {
                TimeSpan tt = new TimeSpan(0, 0, 0, 0, 250);
                _sender = sender;
                Device.StartTimer(tt, ClickHandle30);
            }
            clickCount++;
        }//end first_clicked
        bool ClickHandle30()
        {
            if (clickCount > 1)
            {
                thirtyButton.BackgroundColor = Color.Red;
            }
            else
            {
                thirtyButton.BackgroundColor = Color.Yellow;
            }
            clickCount = 0;
            _sender = null;
            return false;
        }//end clickHandle


        //Button 31
        private void thirtyone_Clicked(object sender, EventArgs e)
        {
            //firstButton.BackgroundColor = Color.Yellow;
            if (clickCount < 1)
            {
                TimeSpan tt = new TimeSpan(0, 0, 0, 0, 250);
                _sender = sender;
                Device.StartTimer(tt, ClickHandle31);
            }
            clickCount++;
        }//end first_clicked
        bool ClickHandle31()
        {
            if (clickCount > 1)
            {
                thirtyoneButton.BackgroundColor = Color.Red;
            }
            else
            {
                thirtyoneButton.BackgroundColor = Color.Yellow;
            }
            clickCount = 0;
            _sender = null;
            return false;
        }//end clickHandle


        //Button 32
        private void thirtytwo_Clicked(object sender, EventArgs e)
        {
            //firstButton.BackgroundColor = Color.Yellow;
            if (clickCount < 1)
            {
                TimeSpan tt = new TimeSpan(0, 0, 0, 0, 250);
                _sender = sender;
                Device.StartTimer(tt, ClickHandle32);
            }
            clickCount++;
        }//end first_clicked
        bool ClickHandle32()
        {
            if (clickCount > 1)
            {
                thirtytwoButton.BackgroundColor = Color.Red;
            }
            else
            {
                thirtytwoButton.BackgroundColor = Color.Yellow;
            }
            clickCount = 0;
            _sender = null;
            return false;
        }//end clickHandle



        //Button 33
        private void thirtyfour_Clicked(object sender, EventArgs e)
        {
            //firstButton.BackgroundColor = Color.Yellow;
            if (clickCount < 1)
            {
                TimeSpan tt = new TimeSpan(0, 0, 0, 0, 250);
                _sender = sender;
                Device.StartTimer(tt, ClickHandle33);
            }
            clickCount++;
        }//end first_clicked
        bool ClickHandle33()
        {
            if (clickCount > 1)
            {
                thirtyfourButton.BackgroundColor = Color.Red;
            }
            else
            {
                thirtyfourButton.BackgroundColor = Color.Yellow;
            }
            clickCount = 0;
            _sender = null;
            return false;
        }//end clickHandle

        //Button 34 thirtyfourty
        private void thirtyfive_Clicked(object sender, EventArgs e)
        {
            //firstButton.BackgroundColor = Color.Yellow;
            if (clickCount < 1)
            {
                TimeSpan tt = new TimeSpan(0, 0, 0, 0, 250);
                _sender = sender;
                Device.StartTimer(tt, ClickHandle35);
            }
            clickCount++;
        }//end first_clicked
        bool ClickHandle35()
        {
            if (clickCount > 1)
            {
                thirtyfiveButton.BackgroundColor = Color.Red;
            }
            else
            {
                thirtyfiveButton.BackgroundColor = Color.Yellow;
            }
            clickCount = 0;
            _sender = null;
            return false;
        }//end clickHandle

        //Button 35  thirtyfourty
        private void thirtysix_Clicked(object sender, EventArgs e)
        {
            //firstButton.BackgroundColor = Color.Yellow;
            if (clickCount < 1)
            {
                TimeSpan tt = new TimeSpan(0, 0, 0, 0, 250);
                _sender = sender;
                Device.StartTimer(tt, ClickHandle36);
            }
            clickCount++;
        }//end first_clicked
        bool ClickHandle36()
        {
            if (clickCount > 1)
            {
                thirtysixButton.BackgroundColor = Color.Red;
            }
            else
            {
                thirtysixButton.BackgroundColor = Color.Yellow;
            }
            clickCount = 0;
            _sender = null;
            return false;
        }//end clickHandle

        //Button 36
        private void thirtyseven_Clicked(object sender, EventArgs e)
        {
            //firstButton.BackgroundColor = Color.Yellow;
            if (clickCount < 1)
            {
                TimeSpan tt = new TimeSpan(0, 0, 0, 0, 250);
                _sender = sender;
                Device.StartTimer(tt, ClickHandle37);
            }
            clickCount++;
        }//end first_clicked
        bool ClickHandle37()
        {
            if (clickCount > 1)
            {
                thirtysevenButton.BackgroundColor = Color.Red;
            }
            else
            {
                thirtysevenButton.BackgroundColor = Color.Yellow;
            }
            clickCount = 0;
            _sender = null;
            return false;
        }//end clickHandle

        //Button 37
        private void thirtyeight_Clicked(object sender, EventArgs e)
        {
            //firstButton.BackgroundColor = Color.Yellow;
            if (clickCount < 1)
            {
                TimeSpan tt = new TimeSpan(0, 0, 0, 0, 250);
                _sender = sender;
                Device.StartTimer(tt, ClickHandle39);
            }
            clickCount++;
        }//end first_clicked
        bool ClickHandle39()
        {
            if (clickCount > 1)
            {
                thirtyeightButton.BackgroundColor = Color.Red;
            }
            else
            {
                thirtyeightButton.BackgroundColor = Color.Yellow;
            }
            clickCount = 0;
            _sender = null;
            return false;
        }//end clickHandle

        //Button 40
        private void forty_Clicked(object sender, EventArgs e)
        {
            //firstButton.BackgroundColor = Color.Yellow;
            if (clickCount < 1)
            {
                TimeSpan tt = new TimeSpan(0, 0, 0, 0, 250);
                _sender = sender;
                Device.StartTimer(tt, ClickHandle40);
            }
            clickCount++;
        }//end first_clicked
        bool ClickHandle40()
        {
            if (clickCount > 1)
            {
                fortyButton.BackgroundColor = Color.Red;
            }
            else
            {
                fortyButton.BackgroundColor = Color.Yellow;
            }
            clickCount = 0;
            _sender = null;
            return false;
        }//end clickHandle

        //Button 41
        private void fortyone_Clicked(object sender, EventArgs e)
        {
            //firstButton.BackgroundColor = Color.Yellow;
            if (clickCount < 1)
            {
                TimeSpan tt = new TimeSpan(0, 0, 0, 0, 250);
                _sender = sender;
                Device.StartTimer(tt, ClickHandle41);
            }
            clickCount++;
        }//end first_clicked
        bool ClickHandle41()
        {
            if (clickCount > 1)
            {
                fortyoneButton.BackgroundColor = Color.Red;
            }
            else
            {
                fortyoneButton.BackgroundColor = Color.Yellow;
            }
            clickCount = 0;
            _sender = null;
            return false;
        }//end clickHandle

        //Button 42
        private void fortytwo_Clicked(object sender, EventArgs e)
        {
            //firstButton.BackgroundColor = Color.Yellow;
            if (clickCount < 1)
            {
                TimeSpan tt = new TimeSpan(0, 0, 0, 0, 250);
                _sender = sender;
                Device.StartTimer(tt, ClickHandle42);
            }
            clickCount++;
        }//end first_clicked
        bool ClickHandle42()
        {
            if (clickCount > 1)
            {
                fortytwoButton.BackgroundColor = Color.Red;
            }
            else
            {
                fortytwoButton.BackgroundColor = Color.Yellow;
            }
            clickCount = 0;
            _sender = null;
            return false;
        }//end clickHandle

        //Button 43
        private void fortythree_Clicked(object sender, EventArgs e)
        {
            //firstButton.BackgroundColor = Color.Yellow;
            if (clickCount < 1)
            {
                TimeSpan tt = new TimeSpan(0, 0, 0, 0, 250);
                _sender = sender;
                Device.StartTimer(tt, ClickHandle43);
            }
            clickCount++;
        }//end first_clicked
        bool ClickHandle43()
        {
            if (clickCount > 1)
            {
                fortythreeButton.BackgroundColor = Color.Red;
            }
            else
            {
                fortythreeButton.BackgroundColor = Color.Yellow;
            }
            clickCount = 0;
            _sender = null;
            return false;
        }//end clickHandle

        //Button 44
        private void fortyfour_Clicked(object sender, EventArgs e)
        {
            //firstButton.BackgroundColor = Color.Yellow;
            if (clickCount < 1)
            {
                TimeSpan tt = new TimeSpan(0, 0, 0, 0, 250);
                _sender = sender;
                Device.StartTimer(tt, ClickHandle44);
            }
            clickCount++;
        }//end first_clicked
        bool ClickHandle44()
        {
            if (clickCount > 1)
            {
                fortyfourButton.BackgroundColor = Color.Red;
            }
            else
            {
                fortyfourButton.BackgroundColor = Color.Yellow;
            }
            clickCount = 0;
            _sender = null;
            return false;
        }//end clickHandle

        private void rules_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("RULES", "One Click Yellow ... Double Click Red ... Four of the same Colors in a Row = Win ... RESET button resets color to start again", "OK");
        }

        private void reset_Clicked(object sender, EventArgs e)
        {
            firstButton.BackgroundColor = Color.DarkBlue;
            secondButton.BackgroundColor = Color.DarkBlue;
            thirdButton.BackgroundColor = Color.DarkBlue;
            fourthButton.BackgroundColor = Color.DarkBlue;
            fifthButton.BackgroundColor = Color.DarkBlue;
            sixthButton.BackgroundColor = Color.DarkBlue;
            seventhButton.BackgroundColor = Color.DarkBlue;
            eigthButton.BackgroundColor = Color.DarkBlue;
            ninthButton.BackgroundColor = Color.DarkBlue;
            tenthButton.BackgroundColor = Color.DarkBlue;
            elevenButton.BackgroundColor = Color.DarkBlue;
            twelveButton.BackgroundColor = Color.DarkBlue;
            thirteenButton.BackgroundColor = Color.DarkBlue;
            fourteenButton.BackgroundColor = Color.DarkBlue;
            fifteenButton.BackgroundColor = Color.DarkBlue;
            sixteenButton.BackgroundColor = Color.DarkBlue;
            seventeenButton.BackgroundColor = Color.DarkBlue;
            eighteenButton.BackgroundColor = Color.DarkBlue;
            nineteenButton.BackgroundColor = Color.DarkBlue;
            twentyButton.BackgroundColor = Color.DarkBlue;
            twentyoneButton.BackgroundColor = Color.DarkBlue;
            twentytwoButton.BackgroundColor = Color.DarkBlue;
            twentythreeButton.BackgroundColor = Color.DarkBlue;
            twentyfourButton.BackgroundColor = Color.DarkBlue;
            twentyfiveButton.BackgroundColor = Color.DarkBlue;
            twentysixButton.BackgroundColor = Color.DarkBlue;
            twentysevenButton.BackgroundColor = Color.DarkBlue;
            twentyeightButton.BackgroundColor = Color.DarkBlue;
            twentynineButton.BackgroundColor = Color.DarkBlue;
            thirtyButton.BackgroundColor = Color.DarkBlue;
            thirtyoneButton.BackgroundColor = Color.DarkBlue;
            thirtytwoButton.BackgroundColor = Color.DarkBlue;
            thirtyfourButton.BackgroundColor = Color.DarkBlue;
            thirtyfiveButton.BackgroundColor = Color.DarkBlue;
            thirtysixButton.BackgroundColor = Color.DarkBlue;
            thirtysevenButton.BackgroundColor = Color.DarkBlue;
            thirtyeightButton.BackgroundColor = Color.DarkBlue;
            fortyButton.BackgroundColor = Color.DarkBlue;
            fortyoneButton.BackgroundColor = Color.DarkBlue;
            fortytwoButton.BackgroundColor = Color.DarkBlue;
            fortythreeButton.BackgroundColor = Color.DarkBlue;
            fortyfourButton.BackgroundColor = Color.DarkBlue;
        }


    }
}

