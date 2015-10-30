using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarbonFootPrint
{
    public partial class frmStartPage : Form
    {
        List<BaseType> baseType = new List<BaseType>();
        public frmStartPage()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            txtBicycleResult.Text = txtBuildingResult.Text = txtCarResult.Text = "Result";
            
            

            double FootPrint;

            if (chckBicycle.Checked)
            {
                if (CheckDataValidity(txtBicycle.Text))
                {
                    BaseType bicycle = new BaseType();
                    BaseType.IncreamentCount();
                    bicycle.Name = "Bicycle" + BaseType.Count;
                    bicycle.ResultCarbonFootPrint = 0;
                    baseType.Add(bicycle);
                    txtBicycleResult.Text = "0";
                    Label l = new Label();
                //    l.Text = "Name is:"+bicycle.Name + " ResultFootPint is:" + bicycle.ResultCarbonFootPrint;
                    listBox3.Items.Add("Name is:" + bicycle.Name + " ResultFootPint is:" + bicycle.ResultCarbonFootPrint);
                }
                else
                {
                    MessageBox.Show("Data entered for bicycle is not valid");
                }
            }
            if (chckBuilding.Checked)
            {
                if (CheckDataValidity(txtBuilding.Text))
                {
                    Building building = new Building();
                    BaseType.IncreamentCount();
                    building.Name = "Building" + BaseType.Count;
                    txtBuildingResult.Text= building.CalculatFootPrints(double.Parse( txtBuilding.Text)).ToString();
                    baseType.Add(building);
                  //  Label l = new Label();
                  //  l.Text = "Name is:"+ building.Name + " SquareFootPrint:" + building.SquareFootPrint.ToString() + " ResultFootPint is:" + building.ResultCarbonFootPrint;
                    listBox2.Items.Add("Name is:" + building.Name + " SquareFootPrint:" + building.SquareFootPrint.ToString() + " ResultFootPint is:" + building.ResultCarbonFootPrint);

                }
                else
                {
                    MessageBox.Show("Data entered for building is not valid");
                }
            }
            if (chckCar.Checked)
            {
                if (CheckDataValidity(txtcar.Text))
                {
                    Car car = new Car();
                    BaseType.IncreamentCount();
                    car.Name = "Car"+BaseType.Count;

                    txtCarResult.Text = car.CalculatFootPrints(double.Parse(txtcar.Text)).ToString();
                    baseType.Add(car);
                 //   Label l = new Label();
                  //  l.Text = "Name is:" + car.Name + " SquareFootPrint:" + car.GasGalons.ToString() + " ResultFootPint is:" + car.ResultCarbonFootPrint;
                    listBox1.Items.Add("Name is:" + car.Name + " SquareFootPrint:" + car.GasGalons.ToString() + " ResultFootPint is:" + car.ResultCarbonFootPrint);
                }
                else
                {
                    MessageBox.Show("Data entered for car is not valid");
                }
            }
        }

        private bool CheckDataValidity(String amount)
        {
            bool IsValid = true;
            try
            {
                double x = Convert.ToDouble(amount);
            }
            catch (Exception e)
            {
                IsValid = false;
            }
            return IsValid;
        }

        private void chckBuilding_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
