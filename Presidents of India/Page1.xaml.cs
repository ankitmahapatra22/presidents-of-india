using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;

namespace Presidents_of_India
{
    public partial class Page1 : PhoneApplicationPage
    {
        public Page1()
        {
            InitializeComponent();
        }


        protected override void OnNavigatedTo(System.Windows.Navigation.NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);

            string myparameter1Value;
            //string myparameter2Value = null;

            NavigationContext.QueryString.TryGetValue("s", out myparameter1Value);
            //NavigationContext.QueryString.TryGetValue("myparameter2", out myparameter2Value);
            
            int a = Convert.ToInt32(myparameter1Value);
            switch (a)
            {   case 0: PageTitle.Text = "President's Name ";
                   textBlock1.Text = "Go back and  move the slider to see  details of any President.";
                    break;
                case 1: PageTitle.Text = "Rajendra Prasad";
                   textBlock1.Text=" 1st President of India \n In office 26 January 1950 – 13 May 1962 \n Prime Minister: Jawaharlal Nehru \n Vice President:	Sarvepalli Radhakrishnan \n Preceded by:	Position Established \n Succeeded by: Sarvepalli Radhakrishnan \n \n Personal details \n \n Born: 3 December 1884 Ziradei, Bihar, India \n Died:	28 February 1963 (aged 78) Patna, Bihar \n Political party:	Indian National Congress \n Spouse(s):	Rajvanshi Devi \n Alma mater:  University of Calcutta";
                    break;
                case 2: PageTitle.Text = " Sarvepalli Radhakrishnan";
                    textBlock1.Text = " 2nd President of India \n In office :13 May 1962 – 13 May 1967 \n Prime Minister :	Jawaharlal Nehru,Gulzarilal Nanda (Acting),Lal Bahadur Shastri,Gulzarilal Nanda (Acting),Indira Gandhi \n Vice President: Zakir Hussain \n Preceded by: Rajendra Prasad \n Succeeded by: Zakir Hussain \n\n Personal details\n\n Born: 5 September 1888,Thiruttani, Tamil Nadu, India\nDied: 17 April 1975 (aged 86)Chennai, India \nPolitical party: IndependentSpouse(s): Sivakamu, Lady Radhakrishnan \n Children: Five daughters,One son\n Alma mater:	Voorhees College,University of Madras";
                    break;
                case 3: PageTitle.Text = " Zakir Hussain";
                    textBlock1.Text=" 3rd President of India \n In office: 13 May 1967 – 3 May 1969 \n Prime Minister:	Indira Gandhi \n Vice President:	Varahagiri Venkata Giri \n Preceded by:	Sarvepalli Radhakrishnan \n Succeeded by:	Varahagiri Venkata Giri (Acting)\n\n Personal details \n\n Born:	8 February 1897,Hyderabad State now Andhra Pradesh \n Died:	3 May 1969 (aged 72)New Delhi, Delhi, India \n Political party:	Independent \n Spouse(s):	Shahjehan Begum \n Alma mater:	Aligarh Muslim University,University of Delhi, Humboldt University of Berlin";
                    break;
                case 4: PageTitle.Text = " V V Giri";
                    textBlock1.Text=" 4th President of India \n In office24: August 1969 – 24 August 1974 \n Prime Minister:	Indira Gandhi \n Vice President:	Gopal Swarup Pathak \n Preceded by:	Mohammad Hidayatullah (Acting) \n Succeeded by:	Fakhruddin Ali Ahmed \n\n Personal details\n\n Born	10 August 1894,Berhampur, British Raj (now India) \n Died:	23 June 1980 (aged 85)Madras, India \n Political party:	Indian National Congress (1916–present) \n Spouse(s):	Saraswati Bai \n Alma mater:	University College Dublin";
                    break;
                case 5: PageTitle.Text = " Fakhruddin Ali Ahmed";
                    textBlock1.Text=" 5th President of India \n In office: 24 August 1974 – 11 February 1977 \n Prime Minister:	Indira Gandhi \n Vice President:	Basappa Danappa Jatti \n Preceded by:	Varahagiri Venkata Giri \n Succeeded by:	Basappa Danappa Jatti \n\n Personal details \n\n Born:	13 May 1905,Delhi, India \n Died:	 11 February 1977 (aged 71)New Delhi, India \n Political party:	Indian National Congress \n Spouse(s):	Begum Abida Ahmed \n Children:	 3 \n Alma mater:	St Catharine's College, Cambridge,St. Stephen's College, Delhi";
                    break;
                case 6: PageTitle.Text = " Neelam Sanjiva Reddy";
                    textBlock1.Text=" 6th President of India \n In office: 25 July 1977 – 25 July 1982 \nPrime Minister: Morarji Desai,Charan Singh,Indira Gandhi \n Vice President: Basappa Danappa Jatti,Mohammad Hidayatullah \n Preceded by:	Basappa Danappa Jatti (Acting) \n Succeeded by:	Zail Singh \n\n Personal details \n\n Born:	19 May 1913,Illur, Madras Presidency, British India (now in Andhra Pradesh) \n Died:	1 June 1996 (aged 83),Bangalore \n Political party:	Janata Party (1977–present) \n Alma mater:	Government Arts College, Anantapur";
                    break;
                case 7: PageTitle.Text = "Giani Zail Singh";
                    textBlock1.Text=" 7th President of India \n In office: July 25, 1982 – July 25, 1987 \n Prime Minister:	Indira Gandhi,Rajiv Gandhi \n Vice President:	Mohammad Hidayatullah,Ramaswamy Venkataraman \n Preceded by:	Neelam Sanjiva Reddy \n Succeeded by:	Ramaswamy Venkataraman \n\n Personal details \n\n Born:	May 5, 1916,Sandhwan, British Raj \n Died:	December 25, 1994 (aged 78)Chandigarh, India \n Political party:	Indian National Congress \n Alma mater:	Shaheed Sikh Missionary College";
                    break;
                case 8: PageTitle.Text = " Ramaswamy Venkataraman";
                    textBlock1.Text=" 8th President of India \n In office: 25 July 1987 – 25 July 1992 \n Prime Minister:	Rajiv Gandhi,Vishwanath Pratap Singh,Chandra Shekhar,Narasimha Rao \n Vice President:	Shankar Dayal Sharma \n Preceded by:	Zail Singh \n Succeeded by:	Shankar Dayal Sharma \n\n Personal details \n\n Born:	4 December 1910,Rajamadam, Madras Presidency, British India(now in Tamil Nadu, India)\n Died:	27 January 2009 (aged 98)New Delhi, India \n Political party:	Indian National Congress \n Spouse(s):	Janaki Venkataraman \n Alma mater:	Loyola College, MadrasMadras Law College";
                    break;
                case 9: PageTitle.Text = " Shankar Dayal Sharma";
                    textBlock1.Text=" 9th President of Indian \n In office: 25 July 1992 – 25 July 1997 \n Prime Minister	Narasimha RaoAtal Bihari VajpayeeH. D. Deve GowdaInder Kumar GujralVice President	Kocheril Raman Narayanan \n Preceded by:	Ramaswamy Venkataraman \n Succeeded by:	Kocheril Raman Narayanan \n\n Personal details \n\n Born:	19 August 1918,Bhopal \n Died:	26 December 1999 (aged 81)New Delhi, India \nPolitical party:	Indian National Congress \n Spouse(s):	Vimala Sharma \n Children:	Two sons,One daughter \n Alma mater: Allahabad University,Agra College,Panjab University, Chandigarh,University of Lucknow,Fitzwilliam College, Cambridge,Harvard University";
                    break;
                case 10: PageTitle.Text = " K R Narayanan";
                    textBlock1.Text=" 10th President of India \n In office: 25 July 1997 – 25 July 2002 \n Prime Minister:	I. K. Gujral,Atal Bihari Vajpayee \n Vice President:	Krishan Kant \n Preceded by:	Shankar Dayal Sharma \n Succeeded by:	A. P. J. Abdul Kalam \n\n Personal details \n\n Born: 27 October 1920,Perumthanam, Travancore,  Kerala, India \n Died:	9 November 2005 (aged 85)New Delhi \n Political party:	Indian National Congress \n Alma mater:	University of Kerala (B.A., M.A.),London School of Economics (B.Sc)";
                    break;
                case 11: PageTitle.Text = " APJ Abdul Kalam";
                    textBlock1.Text=" 11th President of India \n In office: 25 July 2002 – 25 July 2007 \n Prime Minister:	Atal Bihari Vajpayee,Manmohan Singh \n Vice President:	Bhairon Singh Shekhawat \n Preceded by:	Kocheril Raman Narayanan \n Succeeded by:	Pratibha Devisingh Patil \n\n Personal details \n\n Born:	15 October 1931 (age 80),Rameswaram, Tamil Nadu, India) \n Alma mater:	St. Joseph's College, TiruchirappalliMadras Institute of Technology";
                    break;
                case 12: PageTitle.Text = " Pratibha Patil";
                    textBlock1.Text=" 12th President of India \n In office: 25 July 2007 – 25 July 2012 \n Prime Minister:	Manmohan Singh \n Vice President:	Mohammad Hamid Ansari \n Preceded by:	A. P. J. Abdul Kalam \n Succeeded by:	Pranab Mukherjee \n\n Personal details \n\n Born:	 19 December 1934 (age 77),Nadgaon,Maharashtra, India\n Political party:	Indian National Congress \n Spouse(s):	Devisingh Ransingh Shekhawat \n Alma mater:	Mooljee Jetha College, Jalgaon, Government Law College, Mumbai";
                    break;
                case 13: PageTitle.Text = " Pranab Mukherjee";
                    textBlock1.Text=" 13th President of India \n Assumed office: 25 July 2012 \n Prime Minister: Manmohan Singh \n Vice President:	Mohammad Hamid Ansari \n Preceded by:	Pratibha Patil \n\n Personal details \n\n Born:	11 December 1935 (age 76),Mirati, West Bengal ,India \n Political party:	Indian National Congress (1969–1986; 1989–2012),Rashtriya Samajwadi Congress (1986–1989) \n Spouse(s):	Suvra Mukherjee (1957–present)\n Children:	Sharmistha, Abhijit, Indrajit \n Alma mater:	University of Calcutta";
                    break;
                default :
                break;

            }
        }
    }
}