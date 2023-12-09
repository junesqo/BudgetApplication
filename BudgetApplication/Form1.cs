using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BudgetApplication
{
    public partial class Form1 : Form
    {

        List<Product> productList = new List<Product>();
        bool nameIsGood = false, costIsGood = false, genreIsGood = false;


        public Form1()
        {
            InitializeComponent();
            costErrorLabel.Text = "";
            nameErrorLabel.Text = "";
            radioButtonError.Text = "";

            billsTotallbl.Text = "Bills";
            foodTotallbl.Text = "Food";
            autoTotallbl.Text = "Auto";
            entertainmentTotallbl.Text = "Entertainment";
            investmentTotallbl.Text = "Investment";
            shoppingTotallbl.Text = "Shopping";

            pieChart.Titles.Add("Budget Chart");

            pieChart.Series["s1"].IsValueShownAsLabel = true;
            pieChart.Series["s1"].Points.AddXY("Bills", "1");
            pieChart.Series["s1"].Points.AddXY("Food", "1");
            pieChart.Series["s1"].Points.AddXY("Auto", "1");
            pieChart.Series["s1"].Points.AddXY("Entertainment", "1");
            pieChart.Series["s1"].Points.AddXY("Investments", "1");
            pieChart.Series["s1"].Points.AddXY("Shopping", "1");

            this.Text = "Cost Evaluater";
        }

        static void DisplayProducts(List<Product> productList, TextBox outputBox)
        {
            string formattedString2;
            formattedString2 = String.Format("{0,-25}{1,-40}{2,-20}", "Name", "Description", "Price");
            outputBox.AppendText("Costs " + DateTime.Now.ToString("MM/dd/yyyy hh:mm tt") + Environment.NewLine);
            outputBox.AppendText(formattedString2 + Environment.NewLine);

            foreach(Product i in productList)
            {
                outputBox.AppendText(String.Format("{0,-25}{1,-40}${2,-20:0.00}", i.GetName(), i.GetDescription(), i.GetPrice())+Environment.NewLine);
            }

            outputBox.AppendText("" + Environment.NewLine); 
        }


        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void addData_Click(object sender, EventArgs e)
        {
            if(nameField.Text == "")
            {
                nameErrorLabel.Text = "Not a valid name";
                nameIsGood = false;
            } 
            else
            {
                nameIsGood = true;
                nameErrorLabel.Text = "";
            }

            try
            {
                Convert.ToDouble(costField.Text);
                costIsGood = true;
                costErrorLabel.Text = "";
            } catch (Exception) 
            {
                costErrorLabel.Text = "Not a valid number";
                costIsGood=false;
            }
            foreach(RadioButton item in panel1.Controls)
            {
                if(item.Checked == true)
                {
                    genreIsGood=true;
                    radioButtonError.Text = "";
                }
            }

            if (nameIsGood == true && costIsGood == true && genreIsGood == true)
            {
                string productName, productDescription;
                double productPrice;

                productPrice = Convert.ToDouble(costField.Text);
                costField.Text = "";
                costErrorLabel.Text = "";

                productName = nameField.Text;
                nameField.Text = "";
                nameErrorLabel.Text = "";

                productDescription = radioLooper();

                Product newProduct = new Product(productName, productDescription, productPrice);
                productList.Add(newProduct);
            }
            else if (genreIsGood == false) {
                radioButtonError.Text = "Please select a category";
            }
            else
            {
                Console.WriteLine("BIG ERROR");
            }
        }

        private string radioLooper()
        {
            foreach(RadioButton item in panel1.Controls)
            {
                if (item.Checked == true)
                {
                    radioButtonError.Text = "";
                    return item.Text;
                }
            }
            return "";
        }



        private void CostError_Click(object sender, EventArgs e)
        {

        }


        private void genReport_Click(object sender, EventArgs e)
        {
            double autoCost = 0, billsCost = 0, foodCost = 0, entertainmentCost = 0, investmentCost = 0, shoppingCost = 0, sumOfAll = 0;
            foreach (Product i in productList)
            {
                if (i.GetDescription() == "Auto")
                {
                    autoCost = autoCost + i.GetPrice();
                }
                else if (i.GetDescription() == "Bills")
                {
                    billsCost = billsCost + i.GetPrice();
                }
                else if (i.GetDescription() == "Food")
                {
                    foodCost = foodCost + i.GetPrice();
                }
                else if (i.GetDescription() == "Entertainment")
                {
                    entertainmentCost = entertainmentCost + i.GetPrice();
                }
                else if (i.GetDescription() == "Investments")
                {
                    investmentCost += i.GetPrice();
                }
                else
                {
                    shoppingCost = shoppingCost + i.GetPrice();
                }
            }

            sumOfAll = autoCost + billsCost + foodCost + entertainmentCost + investmentCost + shoppingCost;

            DisplayProducts(productList, outputBox);
            pieChart.Series["s1"].Points.Clear();

            if (billsCost != 0)
            {
                pieChart.Series["s1"].Points.AddXY("Bills", Convert.ToString(billsCost));
                billsTotallbl.Text = String.Format("Bills: ${0:0.00} ({1:0.00}%)", billsCost, (billsCost / sumOfAll) * 100);
            }
            if (foodCost != 0)
            {
                pieChart.Series["s1"].Points.AddXY("food", Convert.ToString(foodCost));
                foodTotallbl.Text = String.Format("food: ${0:0.00} ({1:0.00}%)", foodCost, (foodCost / sumOfAll) * 100);
            }
            if (autoCost != 0)
            {
                pieChart.Series["s1"].Points.AddXY("auto", Convert.ToString(autoCost));
                autoTotallbl.Text = String.Format("auto: ${0:0.00} ({1:0.00}%)", autoCost, (autoCost / sumOfAll) * 100);
            }
            if (entertainmentCost != 0)
            {
                pieChart.Series["s1"].Points.AddXY("entertainment", Convert.ToString(entertainmentCost));
                entertainmentTotallbl.Text = String.Format("entertainment: ${0:0.00} ({1:0.00}%)", entertainmentCost, (entertainmentCost / sumOfAll) * 100);
            }
            if (investmentCost != 0)
            {
                pieChart.Series["s1"].Points.AddXY("investments", Convert.ToString(investmentCost));
                investmentTotallbl.Text = String.Format("investments: ${0:0.00} ({1:0.00}%)", investmentCost, (investmentCost / sumOfAll) * 100);
            }
            if (shoppingCost != 0)
            {
                pieChart.Series["s1"].Points.AddXY("shopping", Convert.ToString(shoppingCost));
                shoppingTotallbl.Text = String.Format("shopping: ${0:0.00} ({1:0.00}%)", shoppingCost, (shoppingCost / sumOfAll) * 100);
            }
        }

            

        class Product
        {
            private string name;
            private string description;
            private double price;

            public Product(string productName, string productDescription, double productPrice)
            {
                name = productName;
                description = productDescription;
                price = productPrice;
            }

            public string GetName()
            {
                return name;
            }

            public string GetDescription()
            {
                return description;
            }

            public double GetPrice()
            {
                return price;
            }
        }
    }
}
