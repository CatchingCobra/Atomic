using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Atomic
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {

        //variable Declaration

        public double num1 = 0;
        public double num2 = 0;
        public int atomicnum = 0;
        public string inputNum = "";
        public string resultText = "";
        
        
        List<string> AtomicName = new List<string>();
        public MainPage()
        {
            InitializeComponent();

            string[] elements =
                {   "Hydrogen - (H)", "Helium - (He)", "Lithium - (Li)", "Beryllium - (Be)", "Boron - (B)", "Carbon - (C)", "Nitrogen - (N)", "Oxygen - (O)", "Fluorine - (F)", "Neon - (Ne)", "Sodium - (Na)", "Magnesium - (Mg)",
                    "Aluminum - (Al)", "Silicon - (Si)", "Phosphorus - (P)" , "Sulfur - (S)","Chlorine - (Cl)", "Argon - (Ar)", "Potassium - (K)", "Calcium - (Ca)", "Scandium - (Sc)", "Titanium - (Ti)", "Vanadium - (V)", "Chromium - (Cr)", "Manganese - (Mn)", "Iron - (Fe)",
                    "Cobalt - (Co)", "Nickel - (Ni)", "Copper - (Cu)", "Zinc - (Zn)", "Gallium - (Ga)", "Germanium - (Ge)", "Arsenic - (As)", "Selenium - (Se)", "Bromine - (Br)" , "Krypton - (Kr)", "Rubidium - (Rb)", "Strontium - (Sr)", "Yttrium - (Y)", "Zirconium - (Zr)",
                    "Niobium - (Nb)", "Molybdenum - (Mo)", "Technetium - (Tc)", "Ruthenium - (Ru)", "Rhodium - (Rh)", "Palladium - (Pd)", "Silver - (Ag)", "Cadmium - (Cd)", "Indium - (In)", "Tin - (Sn)", "Antimony - (Sb)", "Tellurium - (Te)", "Iodine - (I)", "Xenon - (Xe)" ,
                    "Cesium - (Cs)", "Barium - (Ba)", "Lanthanum - (La)", "Cerium - (Ce)", "Praseodymium - (Pr)", "Neodymium - (Nd)", "Promethium - (Pm)", "Samarium - (Sm)", "Europium - (Eu)", "Gadolinium - (Gd)", "Terbium - (Tb)", "Dysprosium - (Dy)","Holmium - (Ho)",
                    "Erbium - (Er)", "Thulium - (Tm)", "Ytterbium - (Yb)", "Lutetium - (Lu)", "Hafnium - (Hf)", "Tantalum - (Ta)", "Tungsten - (W)", "Rhenium - (Re)", "Osmium - (Os)", "Iridium - (Ir)", "Platinum - (Pt)", "Gold - (Au)", "Mercury - (Hg)", "Thallium - (Tl)",
                    "Lead - (Pb)", "Bismuth - (Bi)", "Polonium - (Po)", "Astatine - (At)", "Radon - (Rn)", "Francium - (Fr)", "Radium - (Ra)", "Actinium - (Ac)", "Thorium - (Th)", "Protactinium - (Pa)", "Uranium - (U)", "Neptunium - (Np)", "Plutonium - (Pu)", "Americium - (Am)",
                    "Curium - (Cm)", "Berkelium - (Bk)", "Californium - (Cf)", "Einsteinium - (Es)", "Fermium - (Fm)", "Mendelevium - (Md)", "Nobelium - (No)", "Lawrencium - (Lr)", "Rutherfordium - (Rf)", "Dubnium - (Db)", "Seaborgium - (Sg)", "Bohrium - (Bh)", "Hassium - (Hs)",
                    "Meitnerium - (Mt)"
            };
            AtomicName.AddRange(elements);

            
        }

        private void SelectNumber(object sender, EventArgs e)
        {

            Button button = sender as Button;

            if (resultScreen.Text == "0" && button.Text == "0")
            {
                resultScreen.Text = "0";
            }
            else
            {
                resultText += button.Text;
                resultScreen.Text = resultText;
            }

        }

        private void Clear(object sender, EventArgs e)
        {
            num1 = 0;
            num2 = 0;
            
            resultText = "";
            //result = 0;
            resultScreen.Text = "0";

        }

        private void Calculate(object sender, EventArgs e)
        {
            double i = 0;
            bool check = double.TryParse(resultScreen.Text, out i);

            if (check)
            {

                inputNum = resultScreen.Text;
                atomicnum =  (Convert.ToInt32(inputNum));
                atomicnum -= 1;
                if (atomicnum >= AtomicName.Count() || atomicnum == -1)
                {
                    resultScreen.Text = inputNum + " IS NOT AN ATOMIC NUMBER";
                    
                }
                else
                {
                    resultScreen.Text = AtomicName.ElementAt(atomicnum);
                }
                
                

            }  
        }

        
    }
}
